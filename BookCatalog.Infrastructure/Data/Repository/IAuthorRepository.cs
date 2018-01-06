using BookCatalog.DAL.Entities;

namespace BookCatalog.Infrastructure.Data.Repository
{
    public interface IAuthorsRepository : IRepository<int, AuthorEM>
    {
    }
}
