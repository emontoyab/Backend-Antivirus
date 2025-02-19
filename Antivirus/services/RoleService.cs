using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Antivirus.Dtos;
using Antivirus.Models;
using Antivirus.Mappers;

namespace Antivirus.Services
{
    public class RoleService : IRoleService
    {
        private readonly AppDbContext _context;

        public RoleService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<RoleDto>> GetAllRolesAsync()
        {
            var roles = await _context.role.ToListAsync();
            return RoleMapper.MapEntitiesToDtos(roles);
        }

        public async Task<RoleDto> GetRoleByIdAsync(long id)
        {
            var role = await _context.role.FindAsync(id);
            if (role == null) throw new KeyNotFoundException("Role not found");
            return RoleMapper.MapEntityToDto(role);
        }

        public async Task<RoleDto> CreateRoleAsync(RoleDto roleDto)
        {
            var role = RoleMapper.MapDtoToEntity(roleDto);
            _context.role.Add(role);
            await _context.SaveChangesAsync();
            return RoleMapper.MapEntityToDto(role);
        }

        public async Task<RoleDto> UpdateRoleAsync(long id, RoleDto roleDto)
        {
            var role = await _context.role.FindAsync(id);
            if (role == null) throw new KeyNotFoundException("Role not found");

            role.name = roleDto.Name;
            role.trial755 = roleDto.Trial755;

            _context.role.Update(role);
            await _context.SaveChangesAsync();
            return RoleMapper.MapEntityToDto(role);
        }

        public async Task DeleteRoleAsync(long id)
        {
            var role = await _context.role.FindAsync(id);
            if (role == null) throw new KeyNotFoundException("Role not found");

            _context.role.Remove(role);
            await _context.SaveChangesAsync();
        }
    }
}