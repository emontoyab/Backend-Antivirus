using Antivirus.Dtos;
using Antivirus.Models;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace Antivirus.Services
{
    public class InstitutionOpportunitiesService : IInstitutionOpportunitiesService
    {
        private readonly AppDbContext _context;
        private readonly IMapper _mapper;

        public InstitutionOpportunitiesService(AppDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<IEnumerable<InstitutionOpportunitiesDto>> GetAllAsync()
        {
            var entities = await _context.institute_opportunities.ToListAsync();
            return _mapper.Map<IEnumerable<InstitutionOpportunitiesDto>>(entities);
        }

        public async Task<InstitutionOpportunitiesDto?> GetByIdAsync(long id)
        {
            var entity = await _context.institute_opportunities.FindAsync(id);
            return entity == null ? null : _mapper.Map<InstitutionOpportunitiesDto>(entity);
        }

        public async Task<InstitutionOpportunitiesDto> CreateAsync(InstitutionOpportunitiesCreatedDto dto)
        {
            var entity = _mapper.Map<institute_opportunities>(dto);
            _context.institute_opportunities.Add(entity);
            await _context.SaveChangesAsync();
            return _mapper.Map<InstitutionOpportunitiesDto>(entity);
        }

        public async Task<bool> UpdateAsync(long id, InstitutionOpportunitiesCreatedDto dto)
        {
            var entity = await _context.institute_opportunities.FindAsync(id);
            if (entity == null) return false;

            _mapper.Map(dto, entity);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> DeleteAsync(long id)
        {
            var entity = await _context.institute_opportunities.FindAsync(id);
            if (entity == null) return false;

            _context.institute_opportunities.Remove(entity);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}
