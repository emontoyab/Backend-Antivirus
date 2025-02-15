using System.Collections.Generic;
using System.Threading.Tasks;
using Antivirus.DTOs;

namespace Antivirus.Services
{
    public interface IDescriptionsBootcampsService
    {
        Task<IEnumerable<DescriptionsBootcampsDTO>> GetAllAsync();
        Task<DescriptionsBootcampsDTO?> GetByIdAsync(long id);
        Task<DescriptionsBootcampsCreateDto> CreateAsync(DescriptionsBootcampsCreateDto dto);
        Task<DescriptionsBootcampsCreateDto?> UpdateAsync(long id, DescriptionsBootcampsCreateDto dto);
        Task<bool> DeleteAsync(long id);
    }
}
