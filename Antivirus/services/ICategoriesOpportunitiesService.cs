using System.Collections.Generic;
using System.Threading.Tasks;
using Antivirus.DTOs;

namespace Antivirus.Services
{
    public interface ICategoriesOpportunitiesService
    {
        Task<IEnumerable<CategoriesOpportunitiesDTO>> GetAllAsync();
        Task<CategoriesOpportunitiesDTO?> GetByIdAsync(long id);
        Task<CategoriesOpportunitiesDTO> CreateAsync(CategoriesOpportunitiesDTO dto);
        Task<CategoriesOpportunitiesDTO?> UpdateAsync(long id, CategoriesOpportunitiesDTO dto);
        Task<bool> DeleteAsync(long id);
    }
}
