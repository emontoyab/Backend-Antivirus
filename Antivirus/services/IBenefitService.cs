using System.Collections.Generic;
using System.Threading.Tasks;
using Antivirus.Dtos;

namespace Antivirus.Services
{
    public interface IBenefitService
    {
        Task<IEnumerable<BenefitDTO>> GetAllAsync();
        Task<BenefitDTO?> GetByIdAsync(long id);
        Task<BenefitDTO> CreateAsync(BenefitCreateDTO dto);
        Task<BenefitDTO?> UpdateAsync(long id, BenefitCreateDTO dto);
        Task<bool> DeleteAsync(long id);
    }
}