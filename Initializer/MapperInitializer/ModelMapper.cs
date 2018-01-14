using System;
using System.Runtime.Remoting.Channels;
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
                map.CreateMap<BookEM, BookVM>().ReverseMap();

                map.CreateMap<AuthorEM, AuthorVM>().ReverseMap();

                map.CreateMap<AuthorEM, MultiselectAuthorVM>()
                    .ForMember(dest => dest.FullName, opts => opts.MapFrom(src => src.FirstName + " " + src.LastName));
            });
        }
    }
}
