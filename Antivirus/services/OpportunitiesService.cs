using AutoMapper;
using Antivirus.Dtos;
using Antivirus.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Antivirus.Services
{
    public class OpportunitiesService : IOpportunitiesService
    {
        private readonly AppDbContext _context;
        private readonly IMapper _mapper;

        public OpportunitiesService(AppDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<IEnumerable<OpportunitiesDTO>> GetAllAsync()
        {
            var entities = await _context.opportunities.ToListAsync();
            return _mapper.Map<IEnumerable<OpportunitiesDTO>>(entities);
        }

        public async Task<OpportunitiesDTO?> GetByIdAsync(long id)
        {
            var entity = await _context.opportunities.FindAsync(id);
            return entity == null ? null : _mapper.Map<OpportunitiesDTO>(entity);
        }

        public async Task<OpportunitiesCreateDTO> CreateAsync(OpportunitiesCreateDTO dto)
        {
            var entity = _mapper.Map<opportunities>(dto);
            _context.opportunities.Add(entity);
            await _context.SaveChangesAsync();
            return _mapper.Map<OpportunitiesCreateDTO>(entity);
        }

        public async Task<OpportunitiesCreateDTO?> UpdateAsync(long id, OpportunitiesCreateDTO dto)
        {
            var entity = await _context.opportunities.FindAsync(id);
            if (entity == null)
            {
                return null;
            }

            // Actualiza las propiedades (ajusta los nombres de propiedades según corresponda)
            entity.adicional_dates = dto.adicional_dates;
            entity.applications = dto.applications;
            entity.contact_channels = dto.contact_channels;
            entity.descriptions = dto.descriptions;
            entity.guide = dto.guide;
            entity.name = dto.name;
            entity.observations = dto.observations;
            entity.requeriments = dto.requeriments;
            entity.id_categories = dto.id_categories;
            entity.id_status_review = dto.id_status_review;
            entity.oportunity_type = dto.oportunity_type;
            entity.trial755 = dto.trial755;

            _context.opportunities.Update(entity);
            await _context.SaveChangesAsync();
            return _mapper.Map<OpportunitiesCreateDTO>(entity);
        }

        public async Task<bool> DeleteAsync(long id)
        {
            var entity = await _context.opportunities.FindAsync(id);
            if (entity == null)
            {
                return false;
            }
            _context.opportunities.Remove(entity);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}
