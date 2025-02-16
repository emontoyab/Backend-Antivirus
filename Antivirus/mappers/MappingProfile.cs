[2:07 p.m., 16/2/2025] AnthonyM🦊👻: }
[2:08 p.m., 16/2/2025] AnthonyM🦊👻: using Antivirus.Models;
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