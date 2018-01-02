namespace BookCatalog.Infrastructure.Business
{
    #region Namespaces
    using Injection;
    using Web;
    #endregion

    public class BusinessContext : IBusinessContext
    {
        #region Constructor
        public BusinessContext(IWebContext context)
        {
            _webContext = context;
            _factory = context.Factory;
        }
        #endregion

        private IServiceProviderFactory _factory;
        private IWebContext _webContext;

        public IServiceProviderFactory Factory { get { return _factory; } }

        public IWebContext WebContext { get { return _webContext; } }
    }
}
