using Antivirus.Dtos;
using Antivirus.Models;
using AutoMapper;

namespace Antivirus.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<institute_bootcamps, InstituteBootcampsDto>().ReverseMap();
            CreateMap<InstituteBootcampsCreatedDto, institute_bootcamps>().ReverseMap();
        }
    }
}
