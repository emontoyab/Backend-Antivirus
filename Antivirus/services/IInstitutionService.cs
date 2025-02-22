using Antivirus.DTOs;
namespace Antivirus.Services;
 public interface IInstitutionService
    {
        Task<IEnumerable<InstitutionResponseDto>> GetAllAsync();
        Task<InstitutionResponseDto> GetByIdAsync(long id);
        Task<InstitutionResponseDto> CreateAsync(InstitutionRequestDto institutionDto);
        Task<bool> UpdateAsync(long id, InstitutionRequestDto institutionDto);
        Task<bool> DeleteAsync(long id);
    }