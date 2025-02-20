using Antivirus.Models;
using Antivirus.Models.DTOs;
using AutoMapper;

namespace Antivirus.Profiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<BootcampCreateDto, bootcamps>()
            .ForMember(dest => dest.informacion, opt => opt.MapFrom(src => src.Informacion));
            CreateMap<bootcamps, BootcampDto>().ReverseMap();
            CreateMap<bootcamps, BootcampCreateDto>().ReverseMap();
        }
    }
}