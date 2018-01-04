namespace BookCatalog.Infrastructure.Data
{
    #region Namespaces
    using Business;
    using Injection;
    #endregion

    public interface IDataContext
    {
        IServiceProviderFactory Factory { get; }
        IBusinessContext BusinessContext { get; }
    }
}
