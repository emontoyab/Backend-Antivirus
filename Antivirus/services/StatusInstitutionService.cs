using Antivirus.DTOs;
using Antivirus.Mappers;
using Antivirus.Models;
using Microsoft.EntityFrameworkCore;

namespace Antivirus.Services{
public class StatusInstitutionService : IStatusInstitutionService
    {
        private readonly AppDbContext _context;

        public StatusInstitutionService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<StatusInstitutionResponseDto>> GetAllAsync()
        {
            var statuses = await _context.Set<status_institutions>().ToListAsync();
            return statuses.ConvertAll(status => status.ToResponseDto());
        }

        public async Task<StatusInstitutionResponseDto> GetByIdAsync(long id)
        {
            var status = await _context.Set<status_institutions>().FindAsync(id);
            return status?.ToResponseDto();
        }

        public async Task<StatusInstitutionResponseDto> CreateAsync(StatusInstitutionRequestDto statusDto)
        {
            var status = statusDto.ToEntity();
            _context.Set<status_institutions>().Add(status);
            await _context.SaveChangesAsync();
            return status.ToResponseDto();
        }

        public async Task<bool> UpdateAsync(long id, StatusInstitutionRequestDto statusDto)
        {
            var status = await _context.Set<status_institutions>().FindAsync(id);
            if (status == null) return false;

            status.status_review = statusDto.StatusReview;

            _context.Set<status_institutions>().Update(status);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> DeleteAsync(long id)
        {
            var status = await _context.Set<status_institutions>().FindAsync(id);
            if (status == null) return false;

            _context.Set<status_institutions>().Remove(status);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}
