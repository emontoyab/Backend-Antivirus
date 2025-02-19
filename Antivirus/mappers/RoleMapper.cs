// RoleMapper.cs
using System.Collections.Generic;
using System.Linq;
using Antivirus.Dtos;
using Antivirus.Models;

namespace Antivirus.Mappers
{
    public static class RoleMapper
    {
        public static role MapDtoToEntity(RoleDto roleDto)
        {
            return new role
            {
                id = roleDto.Id,
                name = roleDto.Name,
                trial755 = roleDto.Trial755
            };
        }

        public static RoleDto MapEntityToDto(role role)
        {
            return new RoleDto
            {
                Id = role.id,
                Name = role.name,
                Trial755 = role.trial755
            };
        }

        public static IEnumerable<RoleDto> MapEntitiesToDtos(IEnumerable<role> roles)
        {
            return roles.Select(MapEntityToDto).ToList();
        }
    }
}