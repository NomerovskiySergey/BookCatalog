namespace BookCatalog.Controllers
{
    #region Namespaces
    using System;
    using BookCatalog.Infrastructure.Web;
    using System.Web.Mvc;
    using BookCatalog.Infrastructure.Injection;
    using System.Configuration;
    #endregion

    public class BaseController : Controller, IWebContext
    {
        private Lazy<IServiceProviderFactory> _factory = new Lazy<IServiceProviderFactory>();
        private string ConectionStringKey = "TestKey";

        public string ConnectionString
        {
            get
            {
                return ConfigurationManager.ConnectionStrings["ConectionStringKey"].ConnectionString;
            }
        }

        public IServiceProviderFactory Factory
        {
            get
            {
                return _factory.Value;
            }
        }
    }
}