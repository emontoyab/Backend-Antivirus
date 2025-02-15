using AutoMapper;
using Antivirus.Models;
using Antivirus.DTOs;

namespace Antivirus.Mappers
{
    public class StatusOpportunitiesProfile : Profile
    {
        public StatusOpportunitiesProfile()
        {
            CreateMap<status_opportunities, StatusOpportunitiesDTO>().ReverseMap();
            CreateMap<status_opportunities, StatusOpportunitiesCreateDto>().ReverseMap();
        }
    }
}
