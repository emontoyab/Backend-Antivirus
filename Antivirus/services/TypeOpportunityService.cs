using Antivirus.DTOs;
using Antivirus.Mappers;
using Antivirus.Models;
using Microsoft.EntityFrameworkCore;

namespace Antivirus.Services{
 public class TypeOpportunityService : ITypeOpportunityService
    {
        private readonly AppDbContext _context;

        public TypeOpportunityService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<TypeOpportunityResponseDto>> GetAllAsync()
        {
            var opportunities = await _context.Set<type_opportunities>().ToListAsync();
            return opportunities.ConvertAll(opp => opp.ToResponseDto());
        }

        public async Task<TypeOpportunityResponseDto> GetByIdAsync(long id)
        {
            var opportunity = await _context.Set<type_opportunities>().FindAsync(id);
            return opportunity?.ToResponseDto();
        }

        public async Task<TypeOpportunityResponseDto> CreateAsync(TypeOpportunityRequestDto opportunityDto)
        {
            var opportunity = opportunityDto.ToEntity();
            _context.Set<type_opportunities>().Add(opportunity);
            await _context.SaveChangesAsync();
            return opportunity.ToResponseDto();
        }

        public async Task<bool> UpdateAsync(long id, TypeOpportunityRequestDto opportunityDto)
        {
            var opportunity = await _context.Set<type_opportunities>().FindAsync(id);
            if (opportunity == null) return false;

            opportunity.oportunity_type = opportunityDto.OportunityType;

            _context.Set<type_opportunities>().Update(opportunity);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> DeleteAsync(long id)
        {
            var opportunity = await _context.Set<type_opportunities>().FindAsync(id);
            if (opportunity == null) return false;

            _context.Set<type_opportunities>().Remove(opportunity);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}