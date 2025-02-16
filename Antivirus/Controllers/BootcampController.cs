using Antivirus.Models.DTOs;
using Antivirus.Services;
using Microsoft.AspNetCore.Mvc;

namespace Antivirus.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BootcampController : ControllerBase
    {
        private readonly IBootcampService _bootcampService;

        public BootcampController(IBootcampService bootcampService)
        {
            _bootcampService = bootcampService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<BootcampDto>>> GetAll()
        {
            var bootcamps = await _bootcampService.GetAllAsync();
            return Ok(bootcamps);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<BootcampDto>> GetById(long id)
        {
            var bootcamp = await _bootcampService.GetByIdAsync(id);
            if (bootcamp == null) return NotFound();
            return Ok(bootcamp);
        }

        [HttpPost]
        public async Task<ActionResult<BootcampDto>> Create(BootcampDto bootcampDto)
        {
            var bootcamp = await _bootcampService.CreateAsync(bootcampDto);
            return CreatedAtAction(nameof(GetById), new { id = bootcamp.Id }, bootcamp);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(long id, BootcampDto bootcampDto)
        {
            var bootcamp = await _bootcampService.UpdateAsync(id, bootcampDto);
            if (bootcamp == null) return NotFound();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(long id)
        {
            var result = await _bootcampService.DeleteAsync(id);
            if (!result) return NotFound();
            return NoContent();
        }
    }
}