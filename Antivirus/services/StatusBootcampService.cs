using Microsoft.EntityFrameworkCore;
using Antivirus.Mappers;
using Antivirus.Dtos;
using Antivirus.Models;
using Antivirus.Data;

namespace Antivirus.Services
{
    public class StatusBootcampService : IStatusBootcampService
    {
        private readonly AppDbContext _context;

        public StatusBootcampService(AppDbContext context)
        {
            _context = context;
        }
        public async Task CreateAsync(StatusBootcampsCreatedDto Dto)
        {
            var statusBootcamps = StatusBootcampsMapper.MapDtoToEntityCreate(Dto);
            _context.status_bootcamps.Add(statusBootcamps);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var existingStatus = await _context.status_bootcamps.FindAsync(id);
            if (existingStatus != null)
            {
                _context.status_bootcamps.Remove(existingStatus);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<IEnumerable<StatusBootcampsDto>> GetAllAsync()
        {
            var status = await _context.status_bootcamps.ToListAsync();
            return status.Select(StatusBootcampsMapper.MapEntityToDto);
        }

        public async Task<StatusBootcampsDto?> GetByIdAsync(int id)
        {
            var status = await _context.status_bootcamps.FindAsync(id);
            return status != null  ? StatusBootcampsMapper.MapEntityToDto(status) : null;
        }

        public async Task UpdateAsync(int id, StatusBootcampsCreatedDto Dto)
        {
            var status = await _context.status_bootcamps.FindAsync(id);
            if (status != null)
            {
                status.status = Dto.Status;
                await _context.SaveChangesAsync();
            }
        }
    }
}