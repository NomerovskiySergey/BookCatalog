namespace BookCatalog.Infrastructure.Data
{
    #region Namespaces
    using BookCatalog.Infrastructure.Business;
    using BookCatalog.Infrastructure.Injection;
    #endregion

    interface IDataContext
    {
        IServiceProviderFactory Factory { get; }
        IBusinessContext BusinessContext { get; }
    }
}
