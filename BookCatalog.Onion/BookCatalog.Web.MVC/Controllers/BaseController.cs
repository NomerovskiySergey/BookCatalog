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
            WebContext = new WebContext(ConfigurationManager.ConnectionStrings["BookCatalog"].ConnectionString);
        }
        #endregion

        protected IWebContext WebContext { get; }


        protected override void OnException(ExceptionContext filterContext)
        {
            if (filterContext.HttpContext.Request.Headers["X-Requested-With"] == "XMLHttpRequest")
            {
                filterContext.Result = new JsonResult
                {
                    JsonRequestBehavior = JsonRequestBehavior.AllowGet,
                    Data = new {error = true, message = filterContext.Exception.Message}
                };
            }
            else
            {
                base.OnException(filterContext);
            } 
        }
    }
}