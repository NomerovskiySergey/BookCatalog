using BookCatalog.Infrastructure.Context;
using BookCatalog.Infrastructure.Injection;

namespace BookCatalog.DAL.Tools
{
    public class DataContext : IDataContext
    {
        #region Constructors
        public DataContext(IBusinessContext context)
        {
            _factory = context.Factory;
            _connectionString = context.ConnectionString;
        }
        #endregion

        private IServiceProviderFactory _factory;
        private readonly string _connectionString;

        public IServiceProviderFactory Factory => _factory;
        public string ConnectionString => _connectionString;
    }
}
