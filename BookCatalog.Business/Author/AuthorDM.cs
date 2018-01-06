using System;
using System.Collections.Generic;
using BookCatalog.Infrastructure.Business;
using BookCatalog.Infrastructure.Context;
using BookCatalog.ViewModel;

namespace BookCatalog.Business.Author
{
    public class AuthorDM : BaseDomain, IAuthorDM
    {
        #region Constructors
        public AuthorDM(IWebContext context) : base(context) { }

        public AuthorDM(IBusinessContext context) : base(context) { }
        #endregion

        public AuthorVM GetAuthor(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<AuthorVM> GetAuthors()
        {
            throw new NotImplementedException();
        }
    }
}
