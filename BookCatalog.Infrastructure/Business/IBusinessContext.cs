
namespace BookCatalog.Infrastructure.Business
{
    #region Namespaces
    using Injection;
    using Web;
    #endregion

    public interface IBusinessContext
    {
        IWebContext WebContext { get; }
        IServiceProviderFactory Factory { get; }
    }
}
