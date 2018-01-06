using BookCatalog.DAL.Entities;

namespace BookCatalog.Infrastructure.Data.Repository
{
    public interface IBookRepository : IRepository<int, BookEM>
    {
    }
}
