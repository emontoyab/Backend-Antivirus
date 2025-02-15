using Antivirus.DTOs;

namespace Antivirus.Services
{
    public interface IInstitutionService
    {
        Task<IEnumerable<InstitutionDto>> GetAllAsync();
        Task<InstitutionDto> GetByIdAsync(long id);
        Task<InstitutionDto> CreateAsync(InstitutionDto institutionDto);
        Task<bool> UpdateAsync(long id, InstitutionDto institutionDto);
        Task<bool> DeleteAsync(long id);
    }
}