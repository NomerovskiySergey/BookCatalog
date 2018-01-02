namespace BookCatalog.Controllers
{
    #region Namespaces
    using System;
    using BookCatalog.Infrastructure.Web;
    using System.Web.Mvc;
    using BookCatalog.Infrastructure.Injection;
    #endregion

    public class BaseController : Controller, IWebContext
    {
        private Lazy<IServiceProviderFactory> _factory = new Lazy<IServiceProviderFactory>();
        public IServiceProviderFactory Factory
        {
            get
            {
                return _factory.Value;
            }
        }
    }
}