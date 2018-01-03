namespace BookCatalog.DAL.Repositories
{
    #region Namespaces
    using System.Collections.Generic;
    using Infrastructure.Business;
    using Infrastructure.Data;
    #endregion

    public abstract class BaseRepository: DataContext
    {
        #region Constructors
        protected BaseRepository(IBusinessContext context) : base(context){ }
        #endregion
    }
}
