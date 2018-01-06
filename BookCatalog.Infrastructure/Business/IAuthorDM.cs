namespace BookCatalog.Infrastructure.Business
{
    #region Namespaces
    using ViewModel;
    using System.Collections.Generic;
    #endregion
    public interface IAuthorDM
    {
        AuthorVM GetAuthor(int id);
        IEnumerable<AuthorVM> GetAuthors();
    }
}
