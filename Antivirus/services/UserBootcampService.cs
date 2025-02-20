using Antivirus.Dtos;
using Antivirus.Models;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace Antivirus.Services
{
    public class UsersBootcampsService : IUsersBootcampsService
    {
        private readonly AppDbContext _context;
        private readonly IMapper _mapper;

        public UsersBootcampsService(AppDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<IEnumerable<UsersBootcampsDto>> GetAllAsync()
        {
            var entities = await _context.users_bootcamps.ToListAsync();
            return _mapper.Map<IEnumerable<UsersBootcampsDto>>(entities);
        }

        public async Task<UsersBootcampsDto?> GetByIdAsync(long id)
        {
            var entity = await _context.users_bootcamps.FindAsync(id);
            return entity == null ? null : _mapper.Map<UsersBootcampsDto>(entity);
        }

        public async Task<UsersBootcampsDto> CreateAsync(UsersBootcampsCreatedDto dto)
        {
            var entity = _mapper.Map<users_bootcamps>(dto);
            _context.users_bootcamps.Add(entity);
            await _context.SaveChangesAsync();
            return _mapper.Map<UsersBootcampsDto>(entity);
        }

        public async Task<bool> UpdateAsync(long id, UsersBootcampsCreatedDto dto)
        {
            var entity = await _context.users_bootcamps.FindAsync(id);
            if (entity == null) return false;

            _mapper.Map(dto, entity);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> DeleteAsync(long id)
        {
            var entity = await _context.users_bootcamps.FindAsync(id);
            if (entity == null) return false;

            _context.users_bootcamps.Remove(entity);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}
