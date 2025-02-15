using Microsoft.EntityFrameworkCore;
using Antivirus.Mappers;
using Antivirus.Dtos;
using Antivirus.Models;

namespace Antivirus.Services
{
    public class CostBootcampService : ICostsBootcampService
    {
        private readonly AppDbContext _context;

        public CostBootcampService(AppDbContext context)
        {
            _context = context;
        }
        public async Task CreateAsync(CostBootcampsCreatedDto Dto)
        {
            var costBootcamps = CostBootcampsMapper.MapDtoToEntityCreate(Dto);
            _context.costs_bootcamps.Add(costBootcamps);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var existingCost = await _context.costs_bootcamps.FindAsync(id);
            if (existingCost != null)
            {
                _context.costs_bootcamps.Remove(existingCost);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<IEnumerable<CostBootcampsDto>> GetAllAsync()
        {
            var costs = await _context.costs_bootcamps.ToListAsync();
            return costs.Select(CostBootcampsMapper.MapEntityToDto);
        }

        public async Task<CostBootcampsDto?> GetByIdAsync(int id)
        {
            var costs = await _context.costs_bootcamps.FindAsync(id);
            return costs != null  ? CostBootcampsMapper.MapEntityToDto(costs) : null;
        }

        public async Task UpdateAsync(int id, CostBootcampsCreatedDto Dto)
        {
            var costs = await _context.costs_bootcamps.FindAsync(id);
            if (costs != null)
            {
                costs.costs = Dto.Costs;
                await _context.SaveChangesAsync();
            }
        }
    }
}