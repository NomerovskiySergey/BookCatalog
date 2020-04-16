using BookCatalog.Infrastructure.Injection;

namespace BookCatalog.Infrastructure.Context
{
    public interface IDataContext
    {
        IServiceProviderFactory Factory { get; }
        string ConnectionString { get; }
    }
}
