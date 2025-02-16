using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Antivirus.Dtos;
using Antivirus.Models;
using Antivirus.Mappers;

namespace Antivirus.Services
{
    public class UserService
    {
        private readonly DbContext _context;

        public UserService(DbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<UserDto>> GetAllUsersAsync()
        {
            var users = await _context.Set<users>().ToListAsync();
            return UserMapper.MapEntitiesToDtos(users);
        }

        public async Task<UserDto> GetUserByIdAsync(long id)
        {
            var user = await _context.Set<users>().FindAsync(id);
            if (user == null) throw new ResourceNotFoundException("User not found");
            return UserMapper.MapEntityToDto(user);
        }

        public async Task<UserDto> CreateUserAsync(UserDto userDto)
        {
            var user = UserMapper.MapDtoToEntity(userDto);
            _context.Set<users>().Add(user);
            await _context.SaveChangesAsync();
            return UserMapper.MapEntityToDto(user);
        }

        public async Task<UserDto> UpdateUserAsync(long id, UserDto userDto)
        {
            var user = await _context.Set<users>().FindAsync(id);
            if (user == null) throw new ResourceNotFoundException("User not found");

            user.name = userDto.Name;
            user.email = userDto.Email;
            user.last_name = userDto.LastName;
            user.date_birth = userDto.DateBirth;
            user.password = userDto.Password;
            user.trial755 = userDto.Trial755;

            _context.Set<users>().Update(user);
            await _context.SaveChangesAsync();
            return UserMapper.MapEntityToDto(user);
        }

        public async Task DeleteUserAsync(long id)
        {
            var user = await _context.Set<users>().FindAsync(id);
            if (user == null) throw new ResourceNotFoundException("User not found");

            _context.Set<users>().Remove(user);
            await _context.SaveChangesAsync();
        }
    }
}