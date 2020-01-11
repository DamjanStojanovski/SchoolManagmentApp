using AutoMapper;
using Entities;
using WebModels;

namespace Services.Helpers
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<School, SchoolsViewModel>()
                .ForMember(dest => dest.SchoolFullNamme, src => src.MapFrom(x => x.SchoolFullName))
                .ForMember(dest => dest.SchoolShortName, src => src.MapFrom(s => s.SchoolShortName))
                .ForMember(dest => dest.PhoneNumber, src => src.MapFrom(s => s.PhoneNumber))
                .ForMember(dest => dest.WebsiteURL, src => src.MapFrom(s => s.WebsiteURL))
                .ReverseMap()
                .ForMember(dest => dest.Id, src => src.Ignore())
                .ForMember(dest => dest.Muncipality, src => src.Ignore())
                .ForMember(dest => dest.MuncipalityId, src => src.Ignore());
            CreateMap<Muncipality, MuncipalityViewModel>()
               .ForMember(dest => dest.Name, src => src.MapFrom(x => x.Name))
               .ForMember(dest => dest.Schools, src => src.MapFrom(s => s.Schools))
               .ReverseMap()
               .ForMember(dest => dest.Id, src => src.Ignore());
        }
    }
}
