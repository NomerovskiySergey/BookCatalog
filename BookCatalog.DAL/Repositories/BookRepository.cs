using BookCatalog.DAL.Entities;
using BookCatalog.Infrastructure.Context;
using BookCatalog.Infrastructure.Data.Repository;

namespace BookCatalog.DAL.Repositories
{
    public class BooksRepository : DapperBaseRepository<int, BookEM>, IBookRepository
    {
        #region Constructors
        public BooksRepository(IDataContext context) : base(context) { }

        public BooksRepository(IBusinessContext context) : base(context) { }
        #endregion
    }
}
