using Antivirus.Dtos;
using Antivirus.Models;

namespace Antivirus.Mappers
{
    public static class StatusBootcampsMapper
    {
        public static status_bootcamps MapDtoToEntity(StatusBootcampsDto statusBootcampsDto)
        {
            return new status_bootcamps
            {
                status = statusBootcampsDto.Status,
            };
        }

        public static status_bootcamps MapDtoToEntityCreate(StatusBootcampsCreatedDto Dto)
        {
            return new status_bootcamps
            {
                status = Dto.Status,
            };
        }

        public static StatusBootcampsDto MapEntityToDto(status_bootcamps statusBootcamps)
        {
            return new StatusBootcampsDto
            {
                Status = statusBootcamps.status,
            };
        }

        public static StatusBootcampsCreatedDto MapEntityToDtoCreate(status_bootcamps statusBootcamps)
        {
            return new StatusBootcampsCreatedDto
            {
                Status = statusBootcamps.status,
            };
        }

    }
}