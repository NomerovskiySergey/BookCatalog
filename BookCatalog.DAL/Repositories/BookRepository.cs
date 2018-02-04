using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using BookCatalog.DAL.Entities;
using BookCatalog.Infrastructure.Context;
using BookCatalog.Infrastructure.Data.Repository;
using Dapper;
using Dapper.Bulk;
using Dapper.Contrib.Extensions;
using Unity.Interception.Utilities;
using static Dapper.SqlMapper;
using System.Data;

namespace BookCatalog.DAL.Repositories
{
    public class BookRepository : DapperBaseRepository<int, BookEM>, IBookRepository
    {
        #region Constructors
        public BookRepository(IRootContext context) : base(context) { }
        #endregion

        public IEnumerable<DisplayBookEM> GetBooks(string searchExpression, int start, int length, out int totalRow)
        {
            var spName = "USPGetBooks";
            using (SqlConnection connection = new SqlConnection(Context.ConnectionString))
            {
                totalRow = 0;
                DynamicParameters parameter = new DynamicParameters();

                parameter.Add("@SearchExpression", searchExpression, DbType.String, ParameterDirection.Input);
                parameter.Add("@Start", start, DbType.String, ParameterDirection.Input);
                parameter.Add("@Length", length, dbType: DbType.Int32, direction: ParameterDirection.Input);
                parameter.Add("@TotalFilter", totalRow, dbType: DbType.Int32, direction: ParameterDirection.Output);

                var result = connection.Query<DisplayBookEM>(spName, parameter, commandType: CommandType.StoredProcedure);
                totalRow = parameter.Get<int>("TotalFilter");


                return result;
            }
        }

        public void DeleteBook(int bookId)
        {
            var query = @"BEGIN TRANSACTION;
                          DELETE FROM tbl_Authors_Books_Relation WHERE BookId = @BookId
                          DELETE FROM tbl_Book  WHERE Id = @BookId
                         COMMIT;";
            using (SqlConnection connection = new SqlConnection(Context.ConnectionString))
            {
                DynamicParameters parameter = new DynamicParameters();
                parameter.Add("@BookId", bookId, DbType.String, ParameterDirection.Input);

                connection.Execute(query, parameter);
            }
        }


        #region Book creation
        public void CreateBook(BookEM newBook, IEnumerable<int> authorsIds)
        {
            using (SqlConnection connection = new SqlConnection(Context.ConnectionString))
            {
                connection.Open();
                using (var transaction = connection.BeginTransaction())
                {
                    var bookId = InsertBook(newBook, connection, transaction);
                    InsertAuthorBookRelation(bookId, authorsIds, connection, transaction);

                    transaction.Commit();
                }
            }
            
        }

        private long InsertBook(BookEM entity, SqlConnection connection, SqlTransaction transaction)
        {
            var newBookId = connection.Insert(entity, transaction);
            return newBookId;
        }

        private void InsertAuthorBookRelation(long bookId, IEnumerable<int> authorsIds, SqlConnection connection, SqlTransaction transaction)
        {
            List<BookAuthorRelationEM> relations = new List<BookAuthorRelationEM>();

            authorsIds.ForEach(f =>
            {
                relations.Add(new BookAuthorRelationEM()
                {
                    AuthorId = f,
                    BookId = Convert.ToInt32(bookId)
                });
            });

            connection.BulkInsert<BookAuthorRelationEM>(relations, transaction);
        }
        #endregion

        #region Book editing
        public EditBookEM GetBook(int bookId)
        {
            var query = @"SELECT B.Id AS Id,
		                         B.Title AS Title,
		                         B.ReleaseDate AS ReleaseDate,
		                         B.Rating AS Rating,
		                         B.PageCount AS PageCount,
		                         A.Id AS AuthorId
                          FROM tbl_Authors_Books_Relation AS ABR
                          JOIN tbl_Author AS A ON ABR.AuthorId = A.Id
                          JOIN tbl_Book AS B ON ABR.BookId = B.Id
                          WHERE B.Id = @bookId";

            using (SqlConnection connection = new SqlConnection(Context.ConnectionString))
            {
                DynamicParameters parameter = new DynamicParameters();
                parameter.Add("@bookId", bookId, DbType.String, ParameterDirection.Input);

                var bookLookup = new Dictionary<int, EditBookEM>();

                connection.Query<EditBookEM,int,EditBookEM>(
                    query, 
                    map: (b, a) =>
                    {
                        EditBookEM book;

                        if (!bookLookup.TryGetValue(b.Id, out book))
                            bookLookup.Add(b.Id, book = b);

                        if (book.AuthorsIds == null)
                            book.AuthorsIds = new List<int>();

                        book.AuthorsIds.Add(a);

                        return b;
                    },
                    splitOn: "AuthorId",
                    param: parameter);

                return bookLookup.Values.FirstOrDefault();
            }
        }

        public void EditBook(BookEM book, IEnumerable<int> authorsIds)
        {
            using (SqlConnection connection = new SqlConnection(Context.ConnectionString))
            {
                connection.Open();
                using (var transaction = connection.BeginTransaction())
                {
                    UpdateBook(book, connection, transaction);
                    UpdateAuthorBookRelation(book.Id, authorsIds, connection, transaction);

                    transaction.Commit();
                }
            }

        }

        private void UpdateBook(BookEM entity, SqlConnection connection, SqlTransaction transaction)
        {
            connection.Update(entity, transaction);
        }

        private void UpdateAuthorBookRelation(long bookId, IEnumerable<int> authorsIds, SqlConnection connection, SqlTransaction transaction)
        {
            var query = @"IF(NOT EXISTS(SELECT 1 FROM tbl_Authors_Books_Relation WHERE AuthorId = @AuthorId AND BookId = @BookId))
                          BEGIN
                                INSERT INTO tbl_Authors_Books_Relation(AuthorId, BookId) VALUES(@AuthorId, @BookId)
                          END
                          ELSE
                          BEGIN
                                UPDATE tbl_Authors_Books_Relation 
                                SET AuthorId = @AuthorId
                                WHERE BookId = @BookId
                          END";

            List<BookAuthorRelationEM> relations = new List<BookAuthorRelationEM>();

            authorsIds.ForEach(f =>
            {
                relations.Add(new BookAuthorRelationEM()
                {
                    AuthorId = f,
                    BookId = Convert.ToInt32(bookId)
                });
            });

            connection.Execute(query, param: relations, transaction: transaction);
        }
        #endregion
    }
}
