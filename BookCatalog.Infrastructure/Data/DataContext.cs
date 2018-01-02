namespace BookCatalog.Infrastructure.Data
{
    #region Namespaces
    using Business;
    using Injection;
    #endregion

    public class DataContext : IDataContext
    {
        #region Constructors
        public DataContext(IBusinessContext context)
        {
            _businessContext = context;
            _factory = context.Factory;
        }
        #endregion

        private IBusinessContext _businessContext;
        private IServiceProviderFactory _factory;

        public IBusinessContext BusinessContext { get { return _businessContext; } }
        public IServiceProviderFactory Factory { get { return _factory; } }
    }
}
