using System;
using System.Collections.Generic;
using BookCatalog.DAL.Entities;
using BookCatalog.Infrastructure.Business;
using BookCatalog.Infrastructure.Context;
using BookCatalog.Infrastructure.Data.Repository;
using BookCatalog.ViewModel;

namespace BookCatalog.Business.Author
{
    public class AuthorDM : BaseDomain, IAuthorDM
    {
        #region Constructors
        public AuthorDM(IRootContext context) : base(context) { }

        #endregion

        public AuthorVM GetAuthor(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<AuthorVM> GetAuthors()
        {
            using (var repo = Context.Factory.GetService<IAuthorRepository>(Context.RootContext))
            {
                return Context.Mapper.MapTo<IEnumerable<AuthorVM>,IEnumerable<AuthorEM>>(repo.GetAll());
            }
        }

        public IEnumerable<MultiselectAuthorVM> GetMultiselectAuthors()
        {
            using (var repo = Context.Factory.GetService<IAuthorRepository>(Context.RootContext))
            {
                return Context.Mapper.MapTo<IEnumerable<MultiselectAuthorVM>, IEnumerable<AuthorEM>>(repo.GetAll());
            }
        }

        public void CreateAuthor(AuthorVM author)
        {
            using (var repo = Context.Factory.GetService<IAuthorRepository>(Context.RootContext))
            {
               repo.Insert(Context.Mapper.MapTo<AuthorEM, AuthorVM>(author));
            }
        }
    }
}
