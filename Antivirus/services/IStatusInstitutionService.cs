using Antivirus.DTOs;

namespace Antivirus.Services
{
    public interface IStatusInstitutionService
    {
        Task<IEnumerable<StatusInstitutionResponseDto>> GetAllAsync();
        Task<StatusInstitutionResponseDto> GetByIdAsync(long id);
        Task<StatusInstitutionResponseDto> CreateAsync(StatusInstitutionRequestDto statusDto);
        Task<bool> UpdateAsync(long id, StatusInstitutionRequestDto statusDto);
        Task<bool> DeleteAsync(long id);
    }}
