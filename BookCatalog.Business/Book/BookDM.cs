using System.Collections.Generic;
using BookCatalog.Infrastructure.Business;
using BookCatalog.Infrastructure.Context;
using BookCatalog.ViewModel;

namespace BookCatalog.Business.Book
{
    public class BookDM : BaseDomain, IBookDM
    {
        #region Constructors
        public BookDM(IWebContext context) : base(context) { }

        public BookDM(IBusinessContext context) : base(context) { }
        #endregion

        public BookVM GetBook(int id)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<BookVM> GetBooks()
        {
            throw new System.NotImplementedException();
        }
    }
}
