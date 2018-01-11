using BookCatalog.DAL.Entities;
using BookCatalog.Infrastructure.Context;
using BookCatalog.Infrastructure.Data.Repository;

namespace BookCatalog.DAL.Repositories
{
    public class BookRepository : DapperBaseRepository<int, BookEM>, IBookRepository
    {
        #region Constructors
        public BookRepository(IDataContext context) : base(context) { }

        public BookRepository(IBusinessContext context) : base(context) { }
        #endregion

    }
}
