using BookCatalog.Infrastructure.Context;
using BookCatalog.Infrastructure.Injection;

namespace BookCatalog.Initializer
{
    public class WebContext : IWebContext
    {
        #region Constructor
        public WebContext(string connectionString)
        {
            _connectionString = connectionString;
            _factory = UnitySetup.CreateServiceProviderFactory();
        }
        #endregion

        private string _connectionString;
        public string ConnectionString => _connectionString;

        IServiceProviderFactory _factory;
        public IServiceProviderFactory Factory => _factory;
    }
}
