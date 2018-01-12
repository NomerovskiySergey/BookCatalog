using BookCatalog.DAL.Entities;
using BookCatalog.Infrastructure.Context;
using BookCatalog.Infrastructure.Data.Repository;

namespace BookCatalog.DAL.Repositories
{
    public class AuthorRepository : DapperBaseRepository<int, AuthorEM>, IAuthorRepository
    {
        #region Constructors
        public AuthorRepository(IRootContext context) : base(context){}
        #endregion
    }
}
