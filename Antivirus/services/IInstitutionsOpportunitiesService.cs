using Antivirus.Dtos;

namespace Antivirus.Services
{
    public interface IInstitutionOpportunitiesService
    {
        Task<IEnumerable<InstitutionOpportunitiesDto>> GetAllAsync();
        Task<InstitutionOpportunitiesDto?> GetByIdAsync(long id);
        Task<InstitutionOpportunitiesDto> CreateAsync(InstitutionOpportunitiesCreatedDto dto);
        Task<bool> UpdateAsync(long id, InstitutionOpportunitiesCreatedDto dto);
        Task<bool> DeleteAsync(long id);
    }
}
