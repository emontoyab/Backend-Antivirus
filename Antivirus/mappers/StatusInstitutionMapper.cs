using Antivirus.DTOs;
using Antivirus.Models;

namespace Antivirus.Mappers
{
    public static class StatusInstitutionMapper
    {
        public static StatusInstitutionResponseDto ToResponseDto(this status_institutions status)
        {
            return new StatusInstitutionResponseDto
            {
                Id = status.id,
                StatusReview = status.status_review
            };
        }

        public static status_institutions ToEntity(this StatusInstitutionRequestDto dto)
        {
            return new status_institutions
            {
                status_review = dto.StatusReview
            };
        }
    }
}
