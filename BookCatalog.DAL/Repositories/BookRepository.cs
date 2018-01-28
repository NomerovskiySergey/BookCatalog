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

        public IEnumerable<BookEM> GetBooks(string searchExpression, int start, int length, out int totalRow)
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

                var result = connection.Query<BookEM>(spName, parameter, commandType: CommandType.StoredProcedure);
                totalRow = parameter.Get<int>("TotalFilter");


                return result;
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
    }
}
