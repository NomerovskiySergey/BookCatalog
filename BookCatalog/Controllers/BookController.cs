using System.Collections.Generic;
using System.Web.Mvc;
using BookCatalog.Infrastructure.Business;
using BookCatalog.ViewModel;
using System.ComponentModel.DataAnnotations;

namespace BookCatalog.Controllers
{
    public class BookController : BaseController
    {
        // GET: Book
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
        public void CreateBook(CreateBookVM newBook)
        {
            if (ModelState.IsValid)
            {
                using (var bookDm = WebContext.Factory.GetService<IBookDM>(WebContext.RootContext))
                {
                    bookDm.CreateBook(newBook);
                }
            }
            else
            {
                throw new ValidationException();
            }
        }

        [HttpPost]
        public RedirectResult DeleteBook(int bookId)
        {
            using (var bookDm = WebContext.Factory.GetService<IBookDM>(WebContext.RootContext))
            {
                bookDm.DeleteBook(bookId);
            }
            return Redirect("/Home/Index");
        }

        [HttpGet]
        public JsonResult GetBook(int bookId)
        {
            using (var bookDm = WebContext.Factory.GetService<IBookDM>(WebContext.RootContext))
            {
                var vm = bookDm.GetBook(bookId);
                return Json(vm, JsonRequestBehavior.AllowGet);
            }
        }

        [HttpPost]
        public JsonResult UpdateBook(BookVM editBook)
        {
            if (ModelState.IsValid)
            {
                using (var bookDm = WebContext.Factory.GetService<IBookDM>(WebContext.RootContext))
                {
                    bookDm.EditBook(editBook);
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