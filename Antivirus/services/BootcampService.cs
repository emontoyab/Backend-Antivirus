using Antivirus.Models;
using Antivirus.Models.DTOs;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Antivirus.Services
{
    public class BootcampService : IBootcampService
    {
        private readonly AppDbContext _context;
        private readonly IMapper _mapper;

        public BootcampService(AppDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<IEnumerable<BootcampDto>> GetAllAsync()
        {
            var bootcamps = await _context.bootcamps.ToListAsync();
            return _mapper.Map<IEnumerable<BootcampDto>>(bootcamps);
        }

        public async Task<BootcampDto> GetByIdAsync(long id)
        {
            var bootcamp = await _context.bootcamps.FindAsync(id);
            return _mapper.Map<BootcampDto>(bootcamp);
        }

        public async Task<BootcampDto> CreateAsync(BootcampDto bootcampDto)
        {
            var bootcamp = _mapper.Map<bootcamps>(bootcampDto);
            _context.bootcamps.Add(bootcamp);
            await _context.SaveChangesAsync();
            return _mapper.Map<BootcampDto>(bootcamp);
        }

        public async Task<BootcampDto> UpdateAsync(long id, BootcampDto bootcampDto)
        {
            var bootcamp = await _context.bootcamps.FindAsync(id);
            if (bootcamp == null) return null;

            // No modificar la propiedad 'id'
            bootcamp.nombre = bootcampDto.Nombre;
            bootcamp.id_costos_id = bootcampDto.IdCostosId;
            bootcamp.id_estado_id = bootcampDto.IdEstadoId;
            bootcamp.id_general_id = bootcampDto.IdGeneralId;
            bootcamp.id_temas_id = bootcampDto.IdTemasId;
            bootcamp.informacion = bootcampDto.Informacion;
            bootcamp.trial751 = bootcampDto.Trial751;

            await _context.SaveChangesAsync();
            return _mapper.Map<BootcampDto>(bootcamp);
        }

        public async Task<bool> DeleteAsync(long id)
        {
            var bootcamp = await _context.bootcamps.FindAsync(id);
            if (bootcamp == null) return false;

            _context.bootcamps.Remove(bootcamp);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}