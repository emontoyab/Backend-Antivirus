using Antivirus.DTOs;

namespace Antivirus.Services
{
    public interface IUserService
    {
        Task<IEnumerable<RegisterUserDto>> GetAllUsersAsync();
        Task<RegisterUserDto> GetUserByIdAsync(long id);
        Task<RegisterUserDto> CreateUserAsync(RegisterUserDto userDto);
        Task<RegisterUserDto> UpdateUserAsync(long id, RegisterUserDto userDto);
        Task<bool> DeleteUserAsync(long id);
    }
}