namespace BookCatalog.Infrastructure.Web
{
   
    #region Namespaces
    using Injection;
    #endregion


    public interface IWebContext
    {
        IServiceProviderFactory Factory { get; }
        string ConnectionString { get; }
    }
}
