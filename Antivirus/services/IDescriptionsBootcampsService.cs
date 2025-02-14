using System.Collections.Generic;
using System.Threading.Tasks;
using Antivirus.DTOs;

namespace Antivirus.Services
{
    public interface IDescriptionsBootcampsService
    {
        Task<IEnumerable<DescriptionsBootcampsDTO>> GetAllAsync();
        Task<DescriptionsBootcampsDTO?> GetByIdAsync(long id);
        Task<DescriptionsBootcampsDTO> CreateAsync(DescriptionsBootcampsDTO dto);
        Task<DescriptionsBootcampsDTO?> UpdateAsync(long id, DescriptionsBootcampsDTO dto);
        Task<bool> DeleteAsync(long id);
    }
}
