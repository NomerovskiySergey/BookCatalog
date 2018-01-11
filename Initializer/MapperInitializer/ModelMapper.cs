using BookCatalog.DAL.Entities;
using BookCatalog.ViewModel;

namespace BookCatalog.Initializer.MapperInitializer
{
    public class ModelMapper
    {
        public static void Init()
        {
            AutoMapper.Mapper.Initialize((map) =>
            {
                map.CreateMap<BookEM, BookVM>();
                map.CreateMap<AuthorEM, AuthorVM>();

                map.CreateMap<BookVM, BookEM>();
                map.CreateMap<AuthorVM, AuthorEM>();
            });
        }
    }
}
