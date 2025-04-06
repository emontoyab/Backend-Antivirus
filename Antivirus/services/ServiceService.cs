using Antivirus.Dtos;
using Antivirus.Models;
using Antivirus.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Antivirus.Services
{
    public class ServiceService : IServiceService
    {
        private readonly AppDbContext _context;

        public ServiceService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<ServiceDTO>> GetAllAsync()
        {
            return await _context.Services
                .Select(s => new ServiceDTO
                {
                    Id = s.Id,
                    Name = s.Name,
                    Description = s.Description,
                    image_url = s.image_url 
                })
                .ToListAsync();
        }

        public async Task<ServiceDTO> GetByIdAsync(long id)
        {
            var service = await _context.Services.FindAsync(id);
            if (service == null) return null;

            return new ServiceDTO
            {
                Id = service.Id,
                Name = service.Name,
                Description = service.Description,
                image_url = service.image_url 
            };
        }

        public async Task<ServiceDTO> CreateAsync(ServiceCreateDTO dto)
        {
            var service = new Service
            {
                Name = dto.Name,
                Description = dto.Description,
                image_url = dto.image_url 
            };

            _context.Services.Add(service);
            await _context.SaveChangesAsync();

            return new ServiceDTO
            {
                Id = service.Id,
                Name = service.Name,
                Description = service.Description,
                image_url = service.image_url 
            };
        }

        public async Task<ServiceDTO> UpdateAsync(long id, ServiceCreateDTO dto)
        {
            var service = await _context.Services.FindAsync(id);
            if (service == null) return null;

            service.Name = dto.Name;
            service.Description = dto.Description;
            service.image_url = dto.image_url; 
            await _context.SaveChangesAsync();

            return new ServiceDTO
            {
                Id = service.Id,
                Name = service.Name,
                Description = service.Description,
                image_url = service.image_url 
            };
        }

        public async Task<bool> DeleteAsync(long id)
        {
            var service = await _context.Services.FindAsync(id);
            if (service == null) return false;

            _context.Services.Remove(service);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}