using Antivirus.Dtos;
using Antivirus.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Antivirus.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class InstituteBootcampsController : ControllerBase
    {
        private readonly IInstituteBootcampsService _service;

        public InstituteBootcampsController(IInstituteBootcampsService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<InstituteBootcampsDto>>> GetAll()
        {
            return Ok(await _service.GetAllAsync());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<InstituteBootcampsDto>> Get(long id)
        {
            var item = await _service.GetByIdAsync(id);
            if (item == null) return NotFound();
            return Ok(item);
        }

        [HttpPost]
        public async Task<ActionResult> Create([FromBody] InstituteBootcampsCreatedDto dto)
        {
            await _service.CreateAsync(dto);
            return CreatedAtAction(nameof(Get), new { id = dto.id_bootcamps }, dto);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> Update(long id, [FromBody] InstituteBootcampsCreatedDto dto)
        {
            var existingItem = await _service.GetByIdAsync(id);
            if (existingItem == null) return NotFound();
            await _service.UpdateAsync(id, dto);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(long id)
        {
            var existingItem = await _service.GetByIdAsync(id);
            if (existingItem == null) return NotFound();
            await _service.DeleteAsync(id);
            return NoContent();
        }
    }
}
