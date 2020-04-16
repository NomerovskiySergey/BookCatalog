using BookCatalog.DAL.Entities;

namespace BookCatalog.Infrastructure.Data.Repository
{
    public interface IAuthorRepository : IRepository<int, AuthorEM>
    {
        DisplayAuthorEM Get(int id);
    }
}
