using AutoMapper;
using Antivirus.Dtos;
using Antivirus.Models; 
using Microsoft.EntityFrameworkCore;
using Antivirus.Data;

namespace Antivirus.Services
{
    public class BenefitService : IBenefitService
    {
        private readonly AppDbContext _context;

        public BenefitService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<BenefitDTO>> GetAllAsync()
        {
            return await _context.Benefits
                .Select(b => new BenefitDTO
                {
                    Id = b.Id,
                    Title = b.Title,
                    Description = b.Description,
                    image_url = b.image_url
                })
                .ToListAsync();
        }

        public async Task<BenefitDTO?> GetByIdAsync(long id)
        {
            var benefit = await _context.Benefits.FindAsync(id);
            if (benefit == null) return null;

            return new BenefitDTO
            {
                Id = benefit.Id,
                Title = benefit.Title,
                Description = benefit.Description,
                image_url = benefit.image_url
            };
        }

        public async Task<BenefitDTO> CreateAsync(BenefitCreateDTO dto)
        {
            var benefit = new Benefits
            {
                Title = dto.Title,
                Description = dto.Description,
                image_url = dto.image_url
            };

            _context.Benefits.Add(benefit);
            await _context.SaveChangesAsync();

            return new BenefitDTO
            {
                Id = benefit.Id,
                Title = benefit.Title,
                Description = benefit.Description,
                image_url = benefit.image_url
            };
        }

        public async Task<BenefitDTO?> UpdateAsync(long id, BenefitCreateDTO dto)
        {
            var benefit = await _context.Benefits.FindAsync(id);
            if (benefit == null) return null;

            benefit.Title = dto.Title;
            benefit.Description = dto.Description;
            benefit.image_url = dto.image_url;

            await _context.SaveChangesAsync();

            return new BenefitDTO
            {
                Id = benefit.Id,
                Title = benefit.Title,
                Description = benefit.Description,
                image_url = benefit.image_url
            };
        }

        public async Task<bool> DeleteAsync(long id)
        {
            var benefit = await _context.Benefits.FindAsync(id);
            if (benefit == null) return false;

            _context.Benefits.Remove(benefit);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}