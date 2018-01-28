using System.Collections.Generic;
using System.Web.Mvc;
using BookCatalog.Infrastructure.Business;
using BookCatalog.ViewModel;
using BookCatalog.ViewModel.DataGridParameters;

namespace BookCatalog.Controllers
{

    public class HomeController : BaseController
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public JsonResult LoadGridData(DataGridInputParamsVM options)
        {
            IEnumerable<BookVM> catalog;

            using (var catalogDm = WebContext.Factory.GetService<IBookDM>(WebContext.RootContext))
            {
                return Json(catalogDm.GetBooks(options));
            }
        }
    }
}