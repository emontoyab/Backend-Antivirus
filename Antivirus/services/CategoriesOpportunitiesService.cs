using AutoMapper;
using Antivirus.DTOs;
using Antivirus.Models; 
using Microsoft.EntityFrameworkCore;

namespace Antivirus.Services
{
    public class CategoriesOpportunitiesService : ICategoriesOpportunitiesService
    {
        private readonly AppDbContext _context;
        private readonly IMapper _mapper;

        public CategoriesOpportunitiesService(AppDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        
        public async Task<IEnumerable<CategoriesOpportunitiesDTO>> GetAllAsync()
        {
            var entities = await _context.categories_opportunities.ToListAsync();
            return _mapper.Map<IEnumerable<CategoriesOpportunitiesDTO>>(entities);
        }

        public async Task<CategoriesOpportunitiesDTO?> GetByIdAsync(long id)
        {
            var entity = await _context.categories_opportunities.FindAsync(id);
            return entity == null ? null : _mapper.Map<CategoriesOpportunitiesDTO>(entity);
        }

        public async Task<CategoriesOpportunitiesDTO> CreateAsync(CategoriesOpportunitiesDTO dto)
        {
            var entity = _mapper.Map<categories_opportunities>(dto);
            _context.categories_opportunities.Add(entity);
            await _context.SaveChangesAsync();
            return _mapper.Map<CategoriesOpportunitiesDTO>(entity);
        }

        public async Task<CategoriesOpportunitiesDTO?> UpdateAsync(long id, CategoriesOpportunitiesDTO dto)
        {
            var entity = await _context.categories_opportunities.FindAsync(id);
            if (entity == null)
            {
                return null;
            }

            // Actualiza los campos
            entity.categories = dto.categories;
            entity.trial751 = dto.trial751;

            _context.categories_opportunities.Update(entity);
            await _context.SaveChangesAsync();
            return _mapper.Map<CategoriesOpportunitiesDTO>(entity);
        }

        public async Task<bool> DeleteAsync(long id)
        {
            var entity = await _context.categories_opportunities.FindAsync(id);
            if (entity == null)
            {
                return false;
            }
            _context.categories_opportunities.Remove(entity);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}
