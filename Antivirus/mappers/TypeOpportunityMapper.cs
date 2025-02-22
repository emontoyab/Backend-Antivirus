
using Antivirus.DTOs;
using Antivirus.Models;

namespace Antivirus.Mappers
{
    public static class TypeOpportunityMapper
    {
        public static TypeOpportunityResponseDto ToResponseDto(this type_opportunities opportunity)
        {
            return new TypeOpportunityResponseDto
            {
                Id = opportunity.id,
                OportunityType = opportunity.oportunity_type
            };
        }

        public static type_opportunities ToEntity(this TypeOpportunityRequestDto dto)
        {
            return new type_opportunities
            {
                oportunity_type = dto.OportunityType
            };
        }
    }
}
