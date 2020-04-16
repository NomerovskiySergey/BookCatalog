using BookCatalog.Infrastructure.Injection;

namespace BookCatalog.Infrastructure.Context { 
    public interface IWebContext
    {
        IRootContext RootContext { get; set; }
        IServiceProviderFactory Factory { get; }
    }
}
