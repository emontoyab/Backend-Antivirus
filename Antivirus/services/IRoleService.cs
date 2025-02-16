using System.Collections.Generic;
using System.Threading.Tasks;
using Antivirus.Dtos;

namespace Antivirus.Services
{
    public interface IRoleService
    {
        Task<IEnumerable<RoleDto>> GetAllRolesAsync();
        Task<RoleDto> GetRoleByIdAsync(long id);
        Task<RoleDto> CreateRoleAsync(RoleDto roleDto);
        Task<RoleDto> UpdateRoleAsync(long id, RoleDto roleDto);
        Task DeleteRoleAsync(long id);
    }
}