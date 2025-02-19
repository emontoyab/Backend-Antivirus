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
            };
        }
        public static RoleDto MapEntityToDto(role role)
        {
            return new RoleDto
            {
                Id = role.id,
                Name = role.name,
            };
        }

        public static RoleCreateDto MapCreateEntityToDto(role role)
        {
            return new RoleCreateDto
            {
                Name = role.name,
            };
        }
        public static role MapCreateDtoToEntity(RoleCreateDto roleCreateDto)
        {
            return new role
            {
                name = roleCreateDto.Name,
            };
        }

        public static IEnumerable<RoleDto> MapEntitiesToDtos(IEnumerable<role> roles)
        {
            return roles.Select(MapEntityToDto).ToList();
        }
    }
}