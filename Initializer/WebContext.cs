using System;
using BookCatalog.Infrastructure.Context;
using BookCatalog.Infrastructure.Injection;

namespace BookCatalog.Initializer
{
    public class WebContext : IWebContext
    {
        #region Constructor
        public WebContext(string connectionString)
        {
            RootContext = new RootContext(connectionString);
        }
        #endregion

        private IServiceProviderFactory _factory;

        public IRootContext RootContext { get; set; }

        public IServiceProviderFactory Factory => RootContext.Factory;
    }
}
