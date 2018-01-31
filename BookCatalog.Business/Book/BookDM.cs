﻿using System.Collections.Generic;
using BookCatalog.DAL.Entities;
using BookCatalog.Infrastructure.Business;
using BookCatalog.Infrastructure.Context;
using BookCatalog.Infrastructure.Data.Repository;
using BookCatalog.ViewModel;
using BookCatalog.ViewModel.DataGridParameters;

namespace BookCatalog.Business.Book
{
    public class BookDM : BaseDomain, IBookDM
    {
        #region Constructors
        public BookDM(IRootContext context) : base(context) { }
        #endregion

        public BookVM GetBook(int id)
        {
            throw new System.NotImplementedException();
        }

        public DataGridOutputParamsVM GetBooks(DataGridInputParamsVM options)
        {
            using (var repo = Context.Factory.GetService<IBookRepository>(Context.RootContext))
            {
                int totalRows;

                var books = repo.GetBooks(options.Search.Value, options.Start, options.Length, out totalRows);

                return new DataGridOutputParamsVM()
                {
                    data = Context.Mapper.MapTo<IEnumerable<BookVM>, IEnumerable<BookEM>>(books),
                    draw = options.Draw,
                    recordsTotal = totalRows,
                    recordsFiltered = totalRows
                };
            }
        }

        public void CreateBook(CreateBookVM newBook)
        {
            using (var repo = Context.Factory.GetService<IBookRepository>(Context.RootContext))
            {
                var newBookEm = Context.Mapper.MapTo<BookEM, CreateBookVM>(newBook);

                repo.CreateBook(newBookEm, newBook.SelectedAuthorsIds);
            }
        }

        public void DeleteBook(int bookId)
        {
            using (var repo = Context.Factory.GetService<IBookRepository>(Context.RootContext))
            {
                repo.DeleteBook(bookId);
            }
        }
    }
}
