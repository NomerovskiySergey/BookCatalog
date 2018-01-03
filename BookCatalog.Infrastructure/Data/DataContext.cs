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
            _connectionString = context.WebContext.ConnectionString;
        }
        #endregion

        private IBusinessContext _businessContext;
        private IServiceProviderFactory _factory;
        public readonly string _connectionString;

        public IBusinessContext BusinessContext => _businessContext;
        public IServiceProviderFactory Factory => _factory;
        public string ConnectionString => _connectionString;
    }
}
