using Antivirus.DTOs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Antivirus.Services
{
    public interface IStatusOpportunitiesService
    {
        Task<IEnumerable<StatusOpportunitiesDTO>> GetAllAsync();
        Task<StatusOpportunitiesDTO?> GetByIdAsync(long id);
        Task<StatusOpportunitiesDTO> CreateAsync(StatusOpportunitiesDTO dto);
        Task<StatusOpportunitiesDTO?> UpdateAsync(long id, StatusOpportunitiesDTO dto);
        Task<bool> DeleteAsync(long id);
    }
}
