namespace BookCatalog.Controllers
{
    #region Namespaces
    using System.Web.Mvc;
    #endregion

    public class HomeController : BaseController
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}