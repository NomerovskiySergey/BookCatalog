using BookCatalog.Infrastructure.Injection;

namespace BookCatalog.Infrastructure.Context
{
    public interface IRootContext
    {
        string ConnectionString { get; }
        IServiceProviderFactory Factory { get; }
        IMapperService Mapper { get; }
    }
}
