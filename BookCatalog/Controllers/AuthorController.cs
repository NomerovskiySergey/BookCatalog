using System.Net;
using System.Web.Mvc;
using BookCatalog.Infrastructure.Business;
using BookCatalog.ViewModel;
using WebGrease.Css.Ast.Selectors;

namespace BookCatalog.Controllers
{
    public class AuthorController : BaseController
    {
        // GET: Author
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateAuthor(AuthorVM newAuthor)
        {
            using (var domain = WebContext.Factory.GetService<IAuthorDM>(WebContext.RootContext))
            {
                domain.CreateAuthor(newAuthor);
            }

            return new HttpStatusCodeResult(HttpStatusCode.OK);
        }
    }
}