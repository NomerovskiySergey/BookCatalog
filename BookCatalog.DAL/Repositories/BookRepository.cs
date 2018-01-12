using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using BookCatalog.DAL.Entities;
using BookCatalog.Infrastructure.Context;
using BookCatalog.Infrastructure.Data.Repository;
using Dapper;
using Dapper.Contrib.Extensions;

namespace BookCatalog.DAL.Repositories
{
    public class BookRepository : DapperBaseRepository<int, BookEM>, IBookRepository
    {
        #region Constructors
        public BookRepository(IRootContext context) : base(context) { }
        #endregion

        public override IEnumerable<BookEM> GetAll()
        {
            using (SqlConnection connection = new SqlConnection(Context.ConnectionString))
            {
                var query = @"SELECT B.[Id],
                                    B.[Title],
                                    B.[ReleaseDate],
                                    B.[Rating],
                                    B.[PageCount],
                                    A.[Id],
                                    A.[FirstName],
                                    A.[LastName]
                                    FROM[tbl_Authors_Books_Relation] AS ABR
                                    INNER JOIN[tbl_Book] AS B ON ABR.[BookId] = B.[Id]
                                    INNER JOIN[tbl_Author] AS A ON A.[Id] = ABR.[AuthorId]";

                var bookLookup = new Dictionary<int,BookEM>();

                connection.Query<BookEM, AuthorEM, BookEM>(query, (b, a) =>
                {
                    BookEM book;

                    if (!bookLookup.TryGetValue(b.Id, out book))
                        bookLookup.Add(b.Id, book = b);

                    if (book.Author == null)
                        book.Author = new List<AuthorEM>();

                    book.Author.Add(a);

                    return book;
                });

                return bookLookup.Values.ToList();

            }
        }

    }
}
