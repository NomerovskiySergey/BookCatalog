namespace BookCatalog.Infrastructure.Web
{
    #region Namespaces
    using Injection;
    #endregion

    public class WebContext : IWebContext
    {
        #region Constructor
        public WebContext(IServiceProviderFactory factory)
        {
            _factory = factory;
        }
        #endregion

        private IServiceProviderFactory _factory;
        public IServiceProviderFactory Factory { get { return _factory; } }
    }
}
