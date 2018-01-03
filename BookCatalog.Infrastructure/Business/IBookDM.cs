namespace BookCatalog.Infrastructure.Business
{
    #region Namespaces
    using ViewModel;
    using System.Collections.Generic;
    #endregion
    public interface IBookDM
    {
        BookVM GetBook(int id);
        IEnumerable<BookVM> GetBooks();
    }
}
