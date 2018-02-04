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
            IEnumerable<MultiselectAuthorVM> authors = new List<MultiselectAuthorVM>();

            using (var authorDm = WebContext.Factory.GetService<IAuthorDM>(WebContext.RootContext))
            {
                authors = authorDm.GetMultiselectAuthors();
            }
            return View(authors);
        }

        [HttpPost]
        public JsonResult LoadGridData(DataGridInputParamsVM options)
        {
            using (var catalogDm = WebContext.Factory.GetService<IBookDM>(WebContext.RootContext))
            {
                var result = Json(catalogDm.GetBooks(options));
                return result;
            }
        }
    }
}