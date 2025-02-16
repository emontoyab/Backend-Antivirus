using System.Collections.Generic;
using System.Threading.Tasks;
using Antivirus.Models.DTOs;

namespace Antivirus.Services
{
    public interface IBootcampService
    {
        Task<IEnumerable<BootcampDto>> GetAllAsync();
        Task<BootcampDto> GetByIdAsync(long id);
        Task<BootcampDto> CreateAsync(BootcampDto bootcampDto);
        Task<BootcampDto> UpdateAsync(long id, BootcampDto bootcampDto);
        Task<bool> DeleteAsync(long id);
    }
}