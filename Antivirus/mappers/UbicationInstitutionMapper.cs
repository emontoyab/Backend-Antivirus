using Antivirus.DTOs;
using Antivirus.Models;

namespace Antivirus.Mappers
{
    public static class UbicationInstitutionMapper
    {
        public static UbicationInstitutionResponseDto ToResponseDto(this ubications_institutions ubication)
        {
            return new UbicationInstitutionResponseDto
            {
                Id = ubication.id,
                Zona = ubication.zona
            };
        }

        public static ubications_institutions ToEntity(this UbicationInstitutionRequestDto dto)
        {
            return new ubications_institutions
            {
                zona = dto.Zona
            };
        }
    }}

   