using System;
using System.Globalization;
using AutoMapper;
using BookCatalog.DAL.Entities;
using BookCatalog.ViewModel;

namespace BookCatalog.Initializer.MapperInitializer
{
    public class ModelMapper
    {
        public static IMapper Init()
        {
            Mapper.Initialize(x =>
            {
                x.AddProfile<MappingProfile>();
            });

            var config = new MapperConfiguration(cfg => {
                cfg.AddProfile<MappingProfile>();
            });

            return config.CreateMapper();
        }
    }

    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<string, DateTime>()
                    .ConvertUsing(s => DateTime.ParseExact(s, "dd.mm.yyyy", CultureInfo.InvariantCulture));

            CreateMap<DateTime, string>()
                .ConvertUsing(s => s.ToString("dd.mm.yyyy"));

            CreateMap<BookEM, BookVM>()
                .ReverseMap();

            CreateMap<DisplayBookEM, BookVM>()
                .ReverseMap();

            CreateMap<EditBookEM, BookVM>()
                .ReverseMap();

            CreateMap<CreateBookVM, BookEM>();

            CreateMap<AuthorEM, AuthorVM>()
                .ReverseMap();

            CreateMap<DisplayAuthorEM, DisplayAuthorVM>();

            CreateMap<AuthorEM, MultiselectAuthorVM>()
                .ForMember(dest => dest.FullName, opts => opts.MapFrom(src => src.FirstName + " " + src.LastName));

        }
    }

}


