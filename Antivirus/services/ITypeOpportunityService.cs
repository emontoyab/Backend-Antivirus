using Antivirus.DTOs;

namespace Antivirus.Services
{
    public interface ITypeOpportunityService
    {
        Task<IEnumerable<TypeOpportunityResponseDto>> GetAllAsync();
        Task<TypeOpportunityResponseDto> GetByIdAsync(long id);
        Task<TypeOpportunityResponseDto> CreateAsync(TypeOpportunityRequestDto opportunityDto);
        Task<bool> UpdateAsync(long id, TypeOpportunityRequestDto opportunityDto);
        Task<bool> DeleteAsync(long id);
    }}