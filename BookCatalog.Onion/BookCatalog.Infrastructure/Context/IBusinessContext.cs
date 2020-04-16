using BookCatalog.Infrastructure.Injection;

namespace BookCatalog.Infrastructure.Context
{
    public interface IBusinessContext
    {
        IRootContext RootContext { get; set; }
        IServiceProviderFactory Factory { get; }
        IMapperService Mapper { get; }
    }
}
