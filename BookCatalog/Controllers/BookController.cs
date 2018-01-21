using System.Collections.Generic;
using System.Web.Mvc;
using BookCatalog.Infrastructure.Business;
using BookCatalog.ViewModel;

namespace BookCatalog.Controllers
{
    public class BookController : BaseController
    {
        // GET: Book
        public ActionResult Create()
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
            using (var bookDm = WebContext.Factory.GetService<IBookDM>(WebContext.RootContext))
            {
                bookDm.CreateBook(newBook);
            }
        }
    }
}