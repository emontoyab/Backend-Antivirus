using Antivirus.Dtos;

namespace Antivirus.Services
{
    public interface IStatusBootcampService
    {
        Task<IEnumerable<StatusBootcampsDto>> GetAllAsync();
        Task<StatusBootcampsDto?> GetByIdAsync(int id);
        Task CreateAsync(StatusBootcampsCreatedDto Dto);
        Task UpdateAsync(int id, StatusBootcampsCreatedDto Dto);
        Task DeleteAsync(int id);

    }
}