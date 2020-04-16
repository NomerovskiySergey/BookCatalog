using BookCatalog.Infrastructure;
using BookCatalog.Infrastructure.Context;
using BookCatalog.Infrastructure.Injection;
using BookCatalog.Initializer.MapperInitializer;

namespace BookCatalog.Initializer
{
    public class RootContext : IRootContext
    {
        #region Constructors
        public RootContext(string connectionString)
        {
            _connectionString = connectionString;
            _factory = UnitySetup.CreateServiceProviderFactory();
            _mapper = new MapperService();
        }
        #endregion

        private string _connectionString;
        private IServiceProviderFactory _factory;
        private IMapperService _mapper;

        public string ConnectionString => _connectionString;

        public IServiceProviderFactory Factory => _factory;
        public IMapperService Mapper => _mapper;
    }
}
