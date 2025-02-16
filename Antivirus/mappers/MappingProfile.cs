using Antivirus.Models;
using Antivirus.Models.DTOs;
using AutoMapper;

namespace Antivirus.Profiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<bootcamps, BootcampDto>().ReverseMap();
        }
    }
}