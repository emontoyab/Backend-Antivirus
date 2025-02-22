using AutoMapper;
using Antivirus.DTOs;
using Antivirus.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using Antivirus.Data;

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

        public async Task<StatusOpportunitiesCreateDto> CreateAsync(StatusOpportunitiesCreateDto dto)
        {
            var entity = _mapper.Map<status_opportunities>(dto);
            _context.status_opportunities.Add(entity);
            await _context.SaveChangesAsync();
            return _mapper.Map<StatusOpportunitiesCreateDto>(entity);
        }

        public async Task<StatusOpportunitiesCreateDto?> UpdateAsync(long id, StatusOpportunitiesCreateDto dto)
        {
            var entity = await _context.status_opportunities.FindAsync(id);
            if (entity == null)
            {
                return null;
            }

            entity.status = dto.status;

            _context.status_opportunities.Update(entity);
            await _context.SaveChangesAsync();
            return _mapper.Map<StatusOpportunitiesCreateDto>(entity);
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
