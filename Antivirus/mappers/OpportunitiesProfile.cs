using AutoMapper;
using Antivirus.Models;
using Antivirus.Dtos;

namespace Antivirus.Mappers
{
    public class OpportunitiesProfile : Profile
    {
        public OpportunitiesProfile()
        {
            CreateMap<opportunities, OpportunitiesDTO>().ReverseMap();
            CreateMap<opportunities, OpportunitiesCreateDTO>().ReverseMap();
        }
    }
}
