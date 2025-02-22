using Antivirus.DTOs;


namespace Antivirus.Services
{
    public interface ITopicsBootcampsService
    {
        Task<IEnumerable<TopicsBootcampsResponseDto>> GetAllAsync();
        Task<TopicsBootcampsResponseDto?> GetByIdAsync(long id);
        Task<TopicsBootcampsResponseDto> CreateAsync(TopicsBootcampsRequestDto dto);
        Task<TopicsBootcampsResponseDto?> UpdateAsync(long id, TopicsBootcampsRequestDto dto);
        Task<bool> DeleteAsync(long id);
    }
}
