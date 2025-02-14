using AutoMapper;
using Antivirus.DTOs;
using Antivirus.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Antivirus.Services
{
    public class StatusOpportunitiesService : IStatusOpportunitiesService
    {
        private readonly AppDbContext _context;
        private readonly IMapper _mapper;

        public StatusOpportunitiesService(AppDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<IEnumerable<StatusOpportunitiesDTO>> GetAllAsync()
        {
            var entities = await _context.status_opportunities.ToListAsync();
            return _mapper.Map<IEnumerable<StatusOpportunitiesDTO>>(entities);
        }

        public async Task<StatusOpportunitiesDTO?> GetByIdAsync(long id)
        {
            var entity = await _context.status_opportunities.FindAsync(id);
            return entity == null ? null : _mapper.Map<StatusOpportunitiesDTO>(entity);
        }

        public async Task<StatusOpportunitiesDTO> CreateAsync(StatusOpportunitiesDTO dto)
        {
            var entity = _mapper.Map<status_opportunities>(dto);
            _context.status_opportunities.Add(entity);
            await _context.SaveChangesAsync();
            return _mapper.Map<StatusOpportunitiesDTO>(entity);
        }

        public async Task<StatusOpportunitiesDTO?> UpdateAsync(long id, StatusOpportunitiesDTO dto)
        {
            var entity = await _context.status_opportunities.FindAsync(id);
            if (entity == null)
            {
                return null;
            }

            entity.status = dto.status;
            entity.trial755 = dto.trial755;

            _context.status_opportunities.Update(entity);
            await _context.SaveChangesAsync();
            return _mapper.Map<StatusOpportunitiesDTO>(entity);
        }

        public async Task<bool> DeleteAsync(long id)
        {
            var entity = await _context.status_opportunities.FindAsync(id);
            if (entity == null)
            {
                return false;
            }
            _context.status_opportunities.Remove(entity);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}
