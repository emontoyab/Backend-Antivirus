using Antivirus.Data;
using Antivirus.DTOs;
using Antivirus.Mappers;
using Antivirus.Models;
using Microsoft.EntityFrameworkCore;

namespace Antivirus.Services
{
    public class InstitutionService : IInstitutionService
    {
        private readonly AppDbContext _context;

        public InstitutionService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<InstitutionResponseDto>> GetAllAsync()
        {
            var institutions = await _context.Set<institutions>().ToListAsync();
            return institutions.ConvertAll(inst => inst.ToResponseDto());
        }

        public async Task<InstitutionResponseDto> GetByIdAsync(long id)
        {
            var institution = await _context.Set<institutions>().FindAsync(id);
            return institution?.ToResponseDto();
        }

        public async Task<InstitutionResponseDto> CreateAsync(InstitutionRequestDto institutionDto)
        {
            var institution = institutionDto.ToEntity();
            _context.Set<institutions>().Add(institution);
            await _context.SaveChangesAsync();
            return institution.ToResponseDto();
        }

        public async Task<bool> UpdateAsync(long id, InstitutionRequestDto institutionDto)
        {
            var institution = await _context.Set<institutions>().FindAsync(id);
            if (institution == null) return false;

            institution.bienestar_link = institutionDto.BienestarLink;
            institution.carer_link = institutionDto.CarerLink;
            institution.directions = institutionDto.Directions;
            institution.general_link = institutionDto.GeneralLink;
            institution.procces_link = institutionDto.ProccesLink;
            institution.id_status = institutionDto.IdStatus;
            institution.ubications_institutions = institutionDto.UbicationsInstitutions;
            institution.name = institutionDto.Name;
            institution.observations = institutionDto.Observations;

            _context.Set<institutions>().Update(institution);
            await _context.SaveChangesAsync();
            return true;
        }
        public async Task<bool> DeleteAsync(long id)
        {
            var institution = await _context.Set<institutions>().FindAsync(id);
            if (institution == null) return false;

            _context.Set<institutions>().Remove(institution);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}