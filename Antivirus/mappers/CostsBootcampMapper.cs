using Antivirus.Dtos;
using Antivirus.Models;

namespace Antivirus.Mappers
{
    public static class CostBootcampsMapper
    {
        public static costs_bootcamps MapDtoToEntity(CostBootcampsDto costsBootcampsDto)
        {
            return new costs_bootcamps
            {
                costs = costsBootcampsDto.Costs,
            };
        }

        public static costs_bootcamps MapDtoToEntityCreate(CostBootcampsCreatedDto Dto)
        {
            return new costs_bootcamps
            {
                costs = Dto.Costs,
            };
        }

        public static CostBootcampsDto MapEntityToDto(costs_bootcamps costsBootcamps)
        {
            return new CostBootcampsDto
            {
                Costs = costsBootcamps.costs,
            };
        }

        public static CostBootcampsCreatedDto MapEntityToDtoCreate(costs_bootcamps costsBootcamps)
        {
            return new CostBootcampsCreatedDto            {
                Costs = costsBootcamps.costs,
            };
        }

    }
}