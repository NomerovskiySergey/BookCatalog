using System;
using System.Globalization;
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
                map.CreateMap<string, DateTime>()
                    .ConvertUsing(s => DateTime.ParseExact(s,"mm/dd/yyyy", CultureInfo.InvariantCulture));

                map.CreateMap<BookEM, BookVM>()
                    .ReverseMap();

                map.CreateMap<AuthorEM, AuthorVM>()
                    .ReverseMap();

                map.CreateMap<AuthorEM, MultiselectAuthorVM>()
                    .ForMember(dest => dest.FullName, opts => opts.MapFrom(src => src.FirstName + " " + src.LastName));

                map.CreateMap<CreateBookVM, BookEM>()
                    .ForMember(dest => dest.Author, opts => opts.Ignore());
            });
        }
    }
}
