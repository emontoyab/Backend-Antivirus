using Antivirus.Dtos;

namespace Antivirus.Services
{
    public interface ICostsBootcampService
    {
        Task<IEnumerable<CostBootcampsDto>> GetAllAsync();
        Task<CostBootcampsDto?> GetByIdAsync(int id);
        Task CreateAsync(CostBootcampsDto costBootcampsDto);
        Task UpdateAsync(int id, CostBootcampsDto costBootcampsDto);
        Task DeleteAsync(int id);

    }
}