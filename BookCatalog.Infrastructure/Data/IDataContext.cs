namespace BookCatalog.Infrastructure.Data
{
    #region Namespaces
    using Business;
    using Injection;
    #endregion

    interface IDataContext
    {
        IServiceProviderFactory Factory { get; }
        IBusinessContext BusinessContext { get; }
    }
}
