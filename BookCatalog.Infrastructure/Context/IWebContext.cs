using BookCatalog.Infrastructure.Injection;

namespace BookCatalog.Infrastructure.Context { 
    public interface IWebContext
    {
        IServiceProviderFactory Factory { get; }
        string ConnectionString { get; }
    }
}
