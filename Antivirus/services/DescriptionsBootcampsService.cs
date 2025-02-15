using AutoMapper;
using Antivirus.DTOs;
using Antivirus.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Antivirus.Services
{
    public class DescriptionsBootcampsService : IDescriptionsBootcampsService
    {
        private readonly AppDbContext _context;
        private readonly IMapper _mapper;

        public DescriptionsBootcampsService(AppDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<IEnumerable<DescriptionsBootcampsDTO>> GetAllAsync()
        {
            var entities = await _context.descriptions_bootcamps.ToListAsync();
            return _mapper.Map<IEnumerable<DescriptionsBootcampsDTO>>(entities);
        }

        public async Task<DescriptionsBootcampsDTO?> GetByIdAsync(long id)
        {
            var entity = await _context.descriptions_bootcamps.FindAsync(id);
            return entity == null ? null : _mapper.Map<DescriptionsBootcampsDTO>(entity);
        }

        public async Task<DescriptionsBootcampsDTO> CreateAsync(DescriptionsBootcampsCreateDto dto)
        {
            var entity = _mapper.Map<descriptions_bootcamps>(dto);
            _context.descriptions_bootcamps.Add(entity);
            await _context.SaveChangesAsync();
            return _mapper.Map<DescriptionsBootcampsDTO>(entity);
        }

        public async Task<DescriptionsBootcampsCreateDto?> UpdateAsync(long id, DescriptionsBootcampsCreateDto dto)
        {
            var entity = await _context.descriptions_bootcamps.FindAsync(id);
            if (entity == null)
            {
                return null;
            }

            // Actualiza los campos
            entity.description = dto.description;

            _context.descriptions_bootcamps.Update(entity);
            await _context.SaveChangesAsync();
            return _mapper.Map<DescriptionsBootcampsCreateDto>(entity);
        }

        public async Task<bool> DeleteAsync(long id)
        {
            var entity = await _context.descriptions_bootcamps.FindAsync(id);
            if (entity == null)
            {
                return false;
            }
            _context.descriptions_bootcamps.Remove(entity);
            await _context.SaveChangesAsync();
            return true;
        }

        Task<DescriptionsBootcampsCreateDto> IDescriptionsBootcampsService.CreateAsync(DescriptionsBootcampsCreateDto dto)
        {
            throw new NotImplementedException();
        }
    }
}
