using BookCatalog.DAL.Entities;
using BookCatalog.Infrastructure.Context;
using BookCatalog.Infrastructure.Data.Repository;

namespace BookCatalog.DAL.Repositories
{
    public class AutorsRepository : DapperBaseRepository<int, AuthorEM>, IAuthorsRepository
    {
        #region Constructors
        public AutorsRepository(IBusinessContext context) : base(context){}

        public AutorsRepository(IDataContext context) : base(context) { }
        #endregion
    }
}
