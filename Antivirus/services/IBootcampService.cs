using System.Collections.Generic;
using System.Threading.Tasks;
using Antivirus.Models.DTOs;

namespace Antivirus.Services
{
    public interface IBootcampService
    {
        Task<IEnumerable<BootcampDto>> GetAllAsync();
        Task<BootcampDto> GetByIdAsync(long id);
        Task CreateAsync(BootcampCreateDto Dto);
        Task<BootcampDto> UpdateAsync(long id, BootcampCreateDto bootcampDto);
        Task<bool> DeleteAsync(long id);
    }
}