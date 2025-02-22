using Antivirus.Data;
using Antivirus.Dtos;
using Antivirus.Models;
using Antivirus.Services.Interfaces;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace Antivirus.Services
{
    public class InstituteBootcampsService : IInstituteBootcampsService
    {
        private readonly AppDbContext _context;
        private readonly IMapper _mapper;

        public InstituteBootcampsService(AppDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<IEnumerable<InstituteBootcampsDto>> GetAllAsync()
        {
            var entities = await _context.institute_bootcamps.ToListAsync();
            return _mapper.Map<IEnumerable<InstituteBootcampsDto>>(entities);
        }

        public async Task<InstituteBootcampsDto?> GetByIdAsync(long id)
        {
            var entity = await _context.institute_bootcamps.FindAsync(id);
            return _mapper.Map<InstituteBootcampsDto?>(entity);
        }

        public async Task CreateAsync(InstituteBootcampsCreatedDto dto)
        {
            var entity = _mapper.Map<institute_bootcamps>(dto);
            _context.institute_bootcamps.Add(entity);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(long id, InstituteBootcampsCreatedDto dto)
        {
            var entity = await _context.institute_bootcamps.FindAsync(id);
            if (entity != null)
            {
                _mapper.Map(dto, entity);
                await _context.SaveChangesAsync();
            }
        }

        public async Task DeleteAsync(long id)
        {
            var entity = await _context.institute_bootcamps.FindAsync(id);
            if (entity != null)
            {
                _context.institute_bootcamps.Remove(entity);
                await _context.SaveChangesAsync();
            }
        }
    }
}
