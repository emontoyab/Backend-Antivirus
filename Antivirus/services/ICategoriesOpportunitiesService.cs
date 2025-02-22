using System.Collections.Generic;
using System.Threading.Tasks;
using Antivirus.Dtos;

namespace Antivirus.Services
{
    public interface ICategoriesOpportunitiesService
    {
        Task<IEnumerable<CategoriesOpportunitiesDTO>> GetAllAsync();
        Task<CategoriesOpportunitiesDTO?> GetByIdAsync(long id);
        Task<CategoriesCreateOpportunitiesDTO> CreateAsync(CategoriesCreateOpportunitiesDTO dto);
        Task<CategoriesCreateOpportunitiesDTO?> UpdateAsync(long id, CategoriesCreateOpportunitiesDTO dto);
        Task<bool> DeleteAsync(long id);
    }
}
