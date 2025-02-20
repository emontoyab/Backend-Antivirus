using Antivirus.DTOs;

namespace Antivirus.Services
{
    public interface IUserOpportunitiesService
    {
        Task<IEnumerable<UserOpportunitiesResponseDto>> GetAllAsync();
        Task<UserOpportunitiesResponseDto?> GetByIdAsync(long id);
        Task<UserOpportunitiesResponseDto> CreateAsync(UserOpportunitiesRequestDto dto);
        Task<UserOpportunitiesResponseDto?> UpdateAsync(long id, UserOpportunitiesRequestDto dto);
        Task<bool> DeleteAsync(long id);
    }
}
