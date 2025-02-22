using Microsoft.EntityFrameworkCore;
using Antivirus.Dtos;
using Antivirus.Models;
using Antivirus.Data;
using AutoMapper;

namespace Antivirus.Services
{
    public class UserRolesService : IUserRolesService
    {
        private readonly AppDbContext _context;
        private readonly IMapper _mapper;

        public UserRolesService(AppDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<IEnumerable<UserRolesDto>> GetAllAsync()
        {
            var userRoles = await _context.user_roles.ToListAsync();
            return _mapper.Map<IEnumerable<UserRolesDto>>(userRoles);
        }

        public async Task<UserRolesDto?> GetByIdAsync(long usersId, long roleId)
        {
            var userRole = await _context.user_roles.FindAsync(usersId, roleId);
            return userRole != null ? _mapper.Map<UserRolesDto>(userRole) : null;
        }

        public async Task CreateAsync(UserRolesCreatedDto dto)
        {
            var userRole = _mapper.Map<user_roles>(dto);
            _context.user_roles.Add(userRole);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(long usersId, long roleId, UserRolesCreatedDto dto)
        {
            var existingUserRole = await _context.user_roles.FindAsync(usersId, roleId);
            if (existingUserRole != null)
            {
                _mapper.Map(dto, existingUserRole);
                await _context.SaveChangesAsync();
            }
        }

        public async Task DeleteAsync(long usersId, long roleId)
        {
            var userRole = await _context.user_roles.FindAsync(usersId, roleId);
            if (userRole != null)
            {
                _context.user_roles.Remove(userRole);
                await _context.SaveChangesAsync();
            }
        }
    }
}