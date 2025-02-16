// RoleService.cs
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Antivirus.Dtos;
using Antivirus.Models;
using Antivirus.Mappers;

namespace Antivirus.Services
{
    public class RoleService
    {
        private readonly DbContext _context;

        public RoleService(DbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<RoleDto>> GetAllRolesAsync()
        {
            var roles = await _context.Set<role>().ToListAsync();
            return RoleMapper.MapEntitiesToDtos(roles);
        }

        public async Task<RoleDto> GetRoleByIdAsync(long id)
        {
            var role = await _context.Set<role>().FindAsync(id);
            if (role == null) throw new KeyNotFoundException("Role not found");
            return RoleMapper.MapEntityToDto(role);
        }

        public async Task<RoleDto> CreateRoleAsync(RoleDto roleDto)
        {
            var role = RoleMapper.MapDtoToEntity(roleDto);
            _context.Set<role>().Add(role);
            await _context.SaveChangesAsync();
            return RoleMapper.MapEntityToDto(role);
        }

        public async Task<RoleDto> UpdateRoleAsync(long id, RoleDto roleDto)
        {
            var role = await _context.Set<role>().FindAsync(id);
            if (role == null) throw new KeyNotFoundException("Role not found");

            role.name = roleDto.Name;
            role.trial755 = roleDto.Trial755;

            _context.Set<role>().Update(role);
            await _context.SaveChangesAsync();
            return RoleMapper.MapEntityToDto(role);
        }

        public async Task DeleteRoleAsync(long id)
        {
            var role = await _context.Set<role>().FindAsync(id);
            if (role == null) throw new KeyNotFoundException("Role not found");

            _context.Set<role>().Remove(role);
            await _context.SaveChangesAsync();
        }
    }
}