using System;
using System.Collections.Generic;
using BookCatalog.ViewModel;

namespace BookCatalog.Infrastructure.Business
{
    public interface IBookDM : IDisposable
    {
        BookVM GetBook(int id);
        IEnumerable<BookVM> GetBooks();
        void CreateBook(CreateBookVM newBook);
    }
}
