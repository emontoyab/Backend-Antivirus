using Antivirus.Dtos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Antivirus.Services
{
    public interface IServiceService
    {
        Task<IEnumerable<ServiceDTO>> GetAllAsync();
        Task<ServiceDTO> GetByIdAsync(long id);
        Task<ServiceDTO> CreateAsync(ServiceCreateDTO dto);
        Task<ServiceDTO> UpdateAsync(long id, ServiceCreateDTO dto);
        Task<bool> DeleteAsync(long id);
    }
}