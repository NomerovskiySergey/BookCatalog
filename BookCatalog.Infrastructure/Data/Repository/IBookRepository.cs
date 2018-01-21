using System.Collections.Generic;
using BookCatalog.DAL.Entities;

namespace BookCatalog.Infrastructure.Data.Repository
{
    public interface IBookRepository : IRepository<int, BookEM>
    {
        void CreateBook(BookEM newBook, IEnumerable<int> authorsIds);
    }
}
