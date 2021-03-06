﻿using System;
using System.Collections.Generic;
using BookCatalog.ViewModel;

namespace BookCatalog.Infrastructure.Business
{
    public interface IAuthorDM : IDisposable
    {
        DisplayAuthorVM GetAuthor(int id);
        IEnumerable<AuthorVM> GetAuthors();
        IEnumerable<MultiselectAuthorVM> GetMultiselectAuthors();
        void CreateAuthor(AuthorVM author);
        void UpdateAuthor(AuthorVM author);
    }
}
