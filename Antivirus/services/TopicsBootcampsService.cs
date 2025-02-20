using AutoMapper;
using Antivirus.DTOs;
using Antivirus.Models;
using Microsoft.EntityFrameworkCore;

using Antivirus.Data;

namespace Antivirus.Services
{
    public class TopicsBootcampsService : ITopicsBootcampsService
    {
        private readonly AppDbContext _context;
        private readonly IMapper _mapper;

        public TopicsBootcampsService(AppDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<IEnumerable<TopicsBootcampsResponseDto>> GetAllAsync()
        {
            var entities = await _context.topics_bootcamps.ToListAsync();
            return _mapper.Map<IEnumerable<TopicsBootcampsResponseDto>>(entities);
        }

        public async Task<TopicsBootcampsResponseDto?> GetByIdAsync(long id)
        {
            var entity = await _context.topics_bootcamps.FindAsync(id);
            return entity == null ? null : _mapper.Map<TopicsBootcampsResponseDto>(entity);
        }

        public async Task<TopicsBootcampsResponseDto> CreateAsync(TopicsBootcampsRequestDto dto)
        {
            var entity = _mapper.Map<topics_bootcamps>(dto);
            _context.topics_bootcamps.Add(entity);
            await _context.SaveChangesAsync();
            return _mapper.Map<TopicsBootcampsResponseDto>(entity);
        }

        public async Task<TopicsBootcampsResponseDto?> UpdateAsync(long id, TopicsBootcampsRequestDto dto)
        {
            var entity = await _context.topics_bootcamps.FindAsync(id);
            if (entity == null)
            {
                return null;
            }

            // Actualiza la propiedad topics
            entity.topics = dto.topics;

            _context.topics_bootcamps.Update(entity);
            await _context.SaveChangesAsync();
            return _mapper.Map<TopicsBootcampsResponseDto>(entity);
        }

        public async Task<bool> DeleteAsync(long id)
        {
            var entity = await _context.topics_bootcamps.FindAsync(id);
            if (entity == null)
            {
                return false;
            }
            _context.topics_bootcamps.Remove(entity);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}
