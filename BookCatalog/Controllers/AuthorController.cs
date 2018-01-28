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
            if (ModelState.IsValid)
            {
                using (var domain = WebContext.Factory.GetService<IAuthorDM>(WebContext.RootContext))
                {
                    domain.CreateAuthor(newAuthor);
                }

                return new HttpStatusCodeResult(HttpStatusCode.OK);
            }

            return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        }

        public ActionResult Edit(int? id)
        {
            if (!id.HasValue) return HttpNotFound();

            using (var domain = WebContext.Factory.GetService<IAuthorDM>(WebContext.RootContext))
            {
                var vm = domain.GetAuthor(id.Value);
                return View(vm);
            }
        }

        [HttpPost]
        public ActionResult Edit(AuthorVM author)
        {
            if (ModelState.IsValid)
            {
                using (var domain = WebContext.Factory.GetService<IAuthorDM>(WebContext.RootContext))
                {
                    domain.UpdateAuthor(author);
                }

                return new HttpStatusCodeResult(HttpStatusCode.OK);
            }

            return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        }
    }
}