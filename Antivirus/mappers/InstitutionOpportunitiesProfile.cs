using AutoMapper;
using Antivirus.Dtos;
using Antivirus.Models;

namespace Antivirus.Mappers
{
    public class InstitutionOpportunitiesProfile : Profile
    {
        public InstitutionOpportunitiesProfile()
        {
            CreateMap<institute_opportunities, InstitutionOpportunitiesDto>();
            CreateMap<InstitutionOpportunitiesCreatedDto, institute_opportunities>();
        }
    }
}
