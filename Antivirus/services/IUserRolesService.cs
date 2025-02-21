namespace Antivirus.Services;
using Antivirus.Dtos;

 public interface IUserRolesService
    {
        Task<IEnumerable<UserRolesDto>> GetAllAsync();
        Task<UserRolesDto?> GetByIdAsync(long usersId, long roleId);
        Task CreateAsync(UserRolesCreatedDto dto);
        Task UpdateAsync(long usersId, long roleId, UserRolesCreatedDto dto);
        Task DeleteAsync(long usersId, long roleId);
    }