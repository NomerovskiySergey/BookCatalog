using  System.Web.Mvc;
using BookCatalog.Infrastructure.Business;

namespace BookCatalog.Controllers
{

    public class HomeController : BaseController
    {
        public ActionResult Index()
        {
            using (var bookDm = WebContext.Factory.GetService<IBookDM>(WebContext))
            {
                bookDm.GetBooks();
            }

            return View();
        }
    }
}