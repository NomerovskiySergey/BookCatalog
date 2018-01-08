using AutoMapper;
using BookCatalog.DAL.Entities;
using BookCatalog.ViewModel;

namespace BookCatalog.Initializer
{
    public class ModelMapper
    {
        public static void Init()
        {
            Mapper.Initialize((map) =>
            {
                map.CreateMap<BookEM, BookVM>();
                map.CreateMap<AuthorEM, AuthorVM>();

                map.CreateMap<BookVM, BookEM>();
                map.CreateMap<AuthorVM, AuthorEM>();
            });
        }
    }
}
