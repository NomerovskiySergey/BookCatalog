namespace BookCatalog.Controllers
{
    
    #region Namespaces
    using System.Web.Mvc;
    using Business.Author;
    #endregion

    public class HomeController : BaseController
    {
        public ActionResult Index()
        {
            var dm = new AuthorDM(this);


            return View();
        }
    }
}