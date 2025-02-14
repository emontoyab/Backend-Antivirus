using AutoMapper;
using Antivirus.Models;
using Antivirus.DTOs;

namespace Antivirus.Mappers
{
    public class OpportunitiesProfile : Profile
    {
        public OpportunitiesProfile()
        {
            CreateMap<opportunities, OpportunitiesDTO>().ReverseMap();
        }
    }
}
