using Antivirus.DTOs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Antivirus.Services
{
    public interface IOpportunitiesService
    {
        Task<IEnumerable<OpportunitiesDTO>> GetAllAsync();
        Task<OpportunitiesDTO?> GetByIdAsync(long id);
        Task<OpportunitiesDTO> CreateAsync(OpportunitiesDTO dto);
        Task<OpportunitiesDTO?> UpdateAsync(long id, OpportunitiesDTO dto);
        Task<bool> DeleteAsync(long id);
    }
}
