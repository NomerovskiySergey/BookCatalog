﻿using System.Collections.Generic;
using BookCatalog.DAL.Entities;
using BookCatalog.Infrastructure.Business;
using BookCatalog.Infrastructure.Context;
using BookCatalog.Infrastructure.Data.Repository;
using BookCatalog.ViewModel;

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

        public IEnumerable<BookVM> GetBooks()
        {
            using (var repo = Context.Factory.GetService<IBookRepository>(Context.RootContext))
            {
                return Context.Mapper.MapTo<IEnumerable<BookVM>, IEnumerable<BookEM>>(repo.GetAll());
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
    }
}
