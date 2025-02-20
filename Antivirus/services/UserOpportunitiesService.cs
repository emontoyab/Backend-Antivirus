using AutoMapper;
using Antivirus.DTOs;
using Antivirus.Models;
using Microsoft.EntityFrameworkCore;
using Antivirus.Data;

namespace Antivirus.Services
{
    public class UserOpportunitiesService : IUserOpportunitiesService
    {
        private readonly AppDbContext _context;
        private readonly IMapper _mapper;

        public UserOpportunitiesService(AppDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<IEnumerable<UserOpportunitiesResponseDto>> GetAllAsync()
        {
            var entities = await _context.user_oportunities.ToListAsync();
            return _mapper.Map<IEnumerable<UserOpportunitiesResponseDto>>(entities);
        }

        public async Task<UserOpportunitiesResponseDto?> GetByIdAsync(long id)
        {
            var entity = await _context.user_oportunities.FindAsync(id);
            return entity == null ? null : _mapper.Map<UserOpportunitiesResponseDto>(entity);
        }

        public async Task<UserOpportunitiesResponseDto> CreateAsync(UserOpportunitiesRequestDto dto)
        {
            var entity = _mapper.Map<user_oportunities>(dto);
            _context.user_oportunities.Add(entity);
            await _context.SaveChangesAsync();
            return _mapper.Map<UserOpportunitiesResponseDto>(entity);
        }

        public async Task<UserOpportunitiesResponseDto?> UpdateAsync(long id, UserOpportunitiesRequestDto dto)
        {
            var entity = await _context.user_oportunities.FindAsync(id);
            if (entity == null)
            {
                return null;
            }

            // Actualiza las propiedades permitidas
            entity.id_opportunity = dto.id_opportunity;
            entity.id_user = dto.id_user;

            _context.user_oportunities.Update(entity);
            await _context.SaveChangesAsync();
            return _mapper.Map<UserOpportunitiesResponseDto>(entity);
        }

        public async Task<bool> DeleteAsync(long id)
        {
            var entity = await _context.user_oportunities.FindAsync(id);
            if (entity == null)
            {
                return false;
            }
            _context.user_oportunities.Remove(entity);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}
