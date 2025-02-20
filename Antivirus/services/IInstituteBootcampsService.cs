using Antivirus.Dtos;

namespace Antivirus.Services.Interfaces
{
    public interface IInstituteBootcampsService
    {
        Task<IEnumerable<InstituteBootcampsDto>> GetAllAsync();
        Task<InstituteBootcampsDto?> GetByIdAsync(long id);
        Task CreateAsync(InstituteBootcampsCreatedDto dto);
        Task UpdateAsync(long id, InstituteBootcampsCreatedDto dto);
        Task DeleteAsync(long id);
    }
}
