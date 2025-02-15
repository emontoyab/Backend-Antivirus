using Antivirus.DTOs;
using Antivirus.Models;

public static class InstitutionMapper
{
    public static InstitutionResponseDto ToResponseDto(this institutions institution)
    {
        return new InstitutionResponseDto
        {
            Id = institution.id,  // ✅ Devuelve el ID en GET
            BienestarLink = institution.bienestar_link,
            CarerLink = institution.carer_link,
            Directions = institution.directions,
            GeneralLink = institution.general_link,
            ProccesLink = institution.procces_link,
            IdStatus = institution.id_status,
            UbicationsInstitutions = institution.ubications_institutions,
            Name = institution.name,
            Observations = institution.observations
        };
    }

    public static institutions ToEntity(this InstitutionRequestDto dto)
    {
        return new institutions
        {
            bienestar_link = dto.BienestarLink,
            carer_link = dto.CarerLink,
            directions = dto.Directions,
            general_link = dto.GeneralLink,
            procces_link = dto.ProccesLink,
            id_status = dto.IdStatus,
            ubications_institutions = dto.UbicationsInstitutions,
            name = dto.Name,
            observations = dto.Observations
        };
    }
}



