namespace BookCatalog.Business.Book
{
    using ViewModel;
    #region Namespaces
    using Infrastructure.Business;
    using Infrastructure.Web;
    using System.Collections.Generic;
    #endregion
    public class BookDM : BusinessContext, IBookDM
    {
        #region Constructors
        public BookDM(IWebContext context) : base(context) { }
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
