using BookCatalog.Infrastructure;
using BookCatalog.Infrastructure.Context;
using BookCatalog.Infrastructure.Injection;
using BookCatalog.Initializer.MapperInitializer;

namespace BookCatalog.Initializer
{
    public class WebContext : IWebContext
    {
        #region Constructor
        public WebContext(string connectionString)
        {
            _connectionString = connectionString;
            _factory = UnitySetup.CreateServiceProviderFactory();
            _mapper = new MapperService();
        }
        #endregion

        private string _connectionString;
        public string ConnectionString => _connectionString;

        IServiceProviderFactory _factory;
        public IServiceProviderFactory Factory => _factory;

        private IMapperService _mapper;
        public IMapperService Mapper => _mapper;
    }
}
