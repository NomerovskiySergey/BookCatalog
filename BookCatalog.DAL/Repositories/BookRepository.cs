namespace BookCatalog.DAL.Repositories
{
    #region Namespaces
    using Entities;
    using Infrastructure.Business;
    using Infrastructure.Data;
    using Infrastructure.Data.Repository;
    #endregion


    public class BooksRepository : DapperBaseRepository<int, BookEM>, IBookRepository
    {
        #region Constructors
        public BooksRepository(IDataContext context) : base(context) { }

        public BooksRepository(IBusinessContext context) : base(context) { }
        #endregion
    }
}
