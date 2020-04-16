using System;
using BookCatalog.ViewModel;
using BookCatalog.ViewModel.DataGridParameters;

namespace BookCatalog.Infrastructure.Business
{
    public interface IBookDM : IDisposable
    {
        BookVM GetBook(int id);
        DataGridOutputParamsVM GetBooks(DataGridInputParamsVM options);
        void CreateBook(CreateBookVM newBook);
        void DeleteBook(int bookId);
        void EditBook(BookVM book);
    }
}
