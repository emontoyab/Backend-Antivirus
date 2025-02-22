using Antivirus.Data;
using Antivirus.DTOs;
using Antivirus.Mappers;
using Antivirus.Models;
using Microsoft.EntityFrameworkCore;

namespace Antivirus.Services{
 public class UbicationInstitutionService : IUbicationInstitutionService
    {
        private readonly AppDbContext _context;

        public UbicationInstitutionService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<UbicationInstitutionResponseDto>> GetAllAsync()
        {
            var ubications = await _context.Set<ubications_institutions>().ToListAsync();
            return ubications.ConvertAll(ubi => ubi.ToResponseDto());
        }

        public async Task<UbicationInstitutionResponseDto> GetByIdAsync(long id)
        {
            var ubication = await _context.Set<ubications_institutions>().FindAsync(id);
            return ubication?.ToResponseDto();
        }

        public async Task<UbicationInstitutionResponseDto> CreateAsync(UbicationInstitutionRequestDto ubicationDto)
        {
            var ubication = ubicationDto.ToEntity();
            _context.Set<ubications_institutions>().Add(ubication);
            await _context.SaveChangesAsync();
            return ubication.ToResponseDto();
        }

        public async Task<bool> UpdateAsync(long id, UbicationInstitutionRequestDto ubicationDto)
        {
            var ubication = await _context.Set<ubications_institutions>().FindAsync(id);
            if (ubication == null) return false;

            ubication.zona = ubicationDto.Zona;

            _context.Set<ubications_institutions>().Update(ubication);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> DeleteAsync(long id)
        {
            var ubication = await _context.Set<ubications_institutions>().FindAsync(id);
            if (ubication == null) return false;

            _context.Set<ubications_institutions>().Remove(ubication);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}
