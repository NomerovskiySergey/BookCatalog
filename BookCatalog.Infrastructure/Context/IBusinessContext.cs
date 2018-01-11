using BookCatalog.Infrastructure.Injection;

namespace BookCatalog.Infrastructure.Context
{
    public interface IBusinessContext
    {
        string ConnectionString { get; }
        IServiceProviderFactory Factory { get; }
        IMapperService MapService { get; }
    }
}
