using System.Configuration;
using System.Web.Mvc;
using BookCatalog.Infrastructure.Context;
using BookCatalog.Initializer;

namespace BookCatalog.Controllers
{
    public class BaseController : Controller
    {
        #region Constructors
        public BaseController()
        {
            _context = new WebContext(ConfigurationManager.ConnectionStrings["BookCatalog"].ConnectionString);
        }
        #endregion

        IWebContext _context;
        protected IWebContext WebContext => _context;
    }
}