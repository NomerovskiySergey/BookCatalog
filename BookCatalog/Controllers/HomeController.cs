using System.Collections.Generic;
using System.Web.Mvc;
using BookCatalog.Infrastructure.Business;
using BookCatalog.ViewModel;

namespace BookCatalog.Controllers
{

    public class HomeController : BaseController
    {
        public ActionResult Index()
        {
            IEnumerable<BookVM> catalog;

            using (var catalogDm = WebContext.Factory.GetService<IBookDM>(WebContext.RootContext))
            {
                catalog = catalogDm.GetBooks();
            }

            return View(catalog);
        }
    }
}