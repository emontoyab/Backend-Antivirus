using Antivirus.DTOs;
using Antivirus.Models;
using Antivirus.Mappers;
using Microsoft.EntityFrameworkCore;
using Antivirus.config;
using Antivirus.Data;

namespace Antivirus.Services
{
    public class UserService : IUserService
    {
        private readonly AppDbContext _context;

        public UserService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<RegisterUserDto>> GetAllUsersAsync()
        {
            var users = await _context.users.ToListAsync();
            return users.Select(UserMapper.MapUserToRegisterUserDto);
        }

        public async Task<RegisterUserDto> GetUserByIdAsync(long id)
        {
            var user = await _context.users.FindAsync(id);
            return user == null ? null : UserMapper.MapUserToRegisterUserDto(user);
        }

        public async Task<RegisterUserDto> CreateUserAsync(RegisterUserDto userDto)
        {
            var user = UserMapper.MapRegisterUserDtoToUser(userDto);
            _context.users.Add(user);
            await _context.SaveChangesAsync();
            return UserMapper.MapUserToRegisterUserDto(user);
        }

        public async Task<RegisterUserDto> UpdateUserAsync(long id, RegisterUserDto userDto)
        {
            var user = await _context.users.FindAsync(id);
            if (user == null) return null;

            user.name = userDto.Name;
            user.last_name = userDto.LastName;
            user.email = userDto.Email;
            user.password = PasswordHasher.HashPassword(userDto.Password);
            user.date_birth = userDto.DateBirth;

            _context.users.Update(user);
            await _context.SaveChangesAsync();
            return UserMapper.MapUserToRegisterUserDto(user);
        }

        public async Task<bool> DeleteUserAsync(long id)
        {
            var user = await _context.users.FindAsync(id);
            if (user == null) return false;

            _context.users.Remove(user);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}