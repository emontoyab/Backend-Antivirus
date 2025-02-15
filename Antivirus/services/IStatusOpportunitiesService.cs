using Antivirus.DTOs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Antivirus.Services
{
    public interface IStatusOpportunitiesService
    {
        Task<IEnumerable<StatusOpportunitiesDTO>> GetAllAsync();
        Task<StatusOpportunitiesDTO?> GetByIdAsync(long id);
        Task<StatusOpportunitiesCreateDto> CreateAsync(StatusOpportunitiesCreateDto dto);
        Task<StatusOpportunitiesCreateDto?> UpdateAsync(long id, StatusOpportunitiesCreateDto dto);
        Task<bool> DeleteAsync(long id);
    }
}
