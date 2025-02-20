using Antivirus.Dtos;

namespace Antivirus.Services
{
    public interface IUsersBootcampsService
    {
        Task<IEnumerable<UsersBootcampsDto>> GetAllAsync();
        Task<UsersBootcampsDto?> GetByIdAsync(long id);
        Task<UsersBootcampsDto> CreateAsync(UsersBootcampsCreatedDto dto);
        Task<bool> UpdateAsync(long id, UsersBootcampsCreatedDto dto);
        Task<bool> DeleteAsync(long id);
    }
}
