using Antivirus.Dtos;

namespace Antivirus.Services
{
    public interface ICostsBootcampService
    {
        Task<IEnumerable<CostBootcampsDto>> GetAllAsync();
        Task<CostBootcampsDto?> GetByIdAsync(int id);
        Task CreateAsync(CostBootcampsCreatedDto Dto);
        Task UpdateAsync(int id, CostBootcampsCreatedDto Dto);
        Task DeleteAsync(int id);

    }
}