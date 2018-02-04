using System.Web.Mvc;
using BookCatalog.Infrastructure.Business;
using BookCatalog.ViewModel;
using System.ComponentModel.DataAnnotations;

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
        public void CreateAuthor(AuthorVM newAuthor)
        {
            if (ModelState.IsValid)
            {
                using (var domain = WebContext.Factory.GetService<IAuthorDM>(WebContext.RootContext))
                {
                    domain.CreateAuthor(newAuthor);
                }
            }
            else
            {
                throw new ValidationException();
            }
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
        public JsonResult Edit(AuthorVM author)
        {
            if (ModelState.IsValid)
            {
                using (var domain = WebContext.Factory.GetService<IAuthorDM>(WebContext.RootContext))
                {
                    domain.UpdateAuthor(author);
                }
            }
            else
            {
                throw new ValidationException();
            }

            return Json(string.Empty);
        }
    }
}