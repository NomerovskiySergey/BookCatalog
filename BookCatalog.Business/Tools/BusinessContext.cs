using BookCatalog.Infrastructure;
using BookCatalog.Infrastructure.Context;
using BookCatalog.Infrastructure.Injection;

namespace BookCatalog.Business.Tools
{
    public class BusinessContext : IBusinessContext
    {
        #region Constructor
        public BusinessContext(IWebContext context)
        {
            _connectionString = context.ConnectionString;
            _factory = context.Factory;
        }
        #endregion

        private IServiceProviderFactory _factory;
        private string _connectionString;
        private IMapperService _mapService;

        public IServiceProviderFactory Factory => _factory; 

        public string ConnectionString => _connectionString;

        public IMapperService MapService => _mapService;
    }
}
