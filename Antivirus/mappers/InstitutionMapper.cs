using Antivirus.DTOs;

namespace Antivirus.Mappers
{
    public static class InstitutionMapper
    {
        public static InstitutionDto ToDto(this Models.institutions institution)
        {
            return new InstitutionDto
            {
                Id = institution.id,
                BienestarLink = institution.bienestar_link,
                CarerLink = institution.carer_link,
                Directions = institution.directions,
                GeneralLink = institution.general_link,
                ProccesLink = institution.procces_link,
                IdStatus = institution.id_status,
                UbicationsInstitutions = institution.ubications_institutions,
                Name = institution.name,
                Observations = institution.observations,
                Trial751 = institution.trial751
            };
        }

        public static Models.institutions ToEntity(this InstitutionDto dto)
        {
            return new Models.institutions
            {
                id = dto.Id,
                bienestar_link = dto.BienestarLink,
                carer_link = dto.CarerLink,
                directions = dto.Directions,
                general_link = dto.GeneralLink,
                procces_link = dto.ProccesLink,
                id_status = dto.IdStatus,
                ubications_institutions = dto.UbicationsInstitutions,
                name = dto.Name,
                observations = dto.Observations,
                trial751 = dto.Trial751
            };
        }
    }
}
