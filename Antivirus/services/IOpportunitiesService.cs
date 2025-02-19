using Antivirus.Dtos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Antivirus.Services
{
    public interface IOpportunitiesService
    {
        Task<IEnumerable<OpportunitiesDTO>> GetAllAsync();
        Task<OpportunitiesDTO?> GetByIdAsync(long id);
        Task<OpportunitiesCreateDTO> CreateAsync(OpportunitiesCreateDTO dto);
        Task<OpportunitiesCreateDTO?> UpdateAsync(long id, OpportunitiesCreateDTO dto);
        Task<bool> DeleteAsync(long id);
    }
}
