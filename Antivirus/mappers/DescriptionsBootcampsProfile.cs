using AutoMapper;
using Antivirus.Models;
using Antivirus.DTOs;

namespace Antivirus.Mappers
{
    public class DescriptionsBootcampsProfile : Profile
    {
        public DescriptionsBootcampsProfile()
        {
            CreateMap<descriptions_bootcamps, DescriptionsBootcampsDTO>().ReverseMap();
        }
    }
}
