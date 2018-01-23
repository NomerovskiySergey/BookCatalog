using System;
using System.Collections.Generic;
using BookCatalog.ViewModel;

namespace BookCatalog.Infrastructure.Business
{
    public interface IAuthorDM : IDisposable
    {
        AuthorVM GetAuthor(int id);
        IEnumerable<AuthorVM> GetAuthors();
        IEnumerable<MultiselectAuthorVM> GetMultiselectAuthors();
        void CreateAuthor(AuthorVM author);
    }
}
