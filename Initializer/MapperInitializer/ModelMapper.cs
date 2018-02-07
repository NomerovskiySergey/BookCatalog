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
                    .ConvertUsing(s => DateTime.ParseExact(s, "dd.mm.yyyy", CultureInfo.InvariantCulture));

                map.CreateMap<DateTime, string>()
                    .ConvertUsing(s => s.ToString("dd.mm.yyyy"));

                map.CreateMap<BookEM, BookVM>()
                    .ReverseMap();

                map.CreateMap<DisplayBookEM, BookVM>()
                    .ReverseMap();

                map.CreateMap<EditBookEM, BookVM>()
                    .ReverseMap();

                map.CreateMap<CreateBookVM, BookEM>();

                map.CreateMap<AuthorEM, AuthorVM>()
                    .ReverseMap();

                map.CreateMap<DisplayAuthorEM, DisplayAuthorVM>();

                map.CreateMap<AuthorEM, MultiselectAuthorVM>()
                    .ForMember(dest => dest.FullName, opts => opts.MapFrom(src => src.FirstName + " " + src.LastName));
            });
        }
    }
}
