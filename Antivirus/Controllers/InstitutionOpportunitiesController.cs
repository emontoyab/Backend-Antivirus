using Antivirus.Dtos;
using Antivirus.Services;
using Microsoft.AspNetCore.Mvc;


namespace Antivirus.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class InstitutionOpportunitiesController : ControllerBase
    {
        private readonly IInstitutionOpportunitiesService _service;

        public InstitutionOpportunitiesController(IInstitutionOpportunitiesService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<InstitutionOpportunitiesDto>>> GetAll()
        {
            var result = await _service.GetAllAsync();
            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<InstitutionOpportunitiesDto>> GetById(long id)
        {
            var result = await _service.GetByIdAsync(id);
            if (result == null) return NotFound();
            return Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult<InstitutionOpportunitiesDto>> Create(InstitutionOpportunitiesCreatedDto dto)
        {
            var created = await _service.CreateAsync(dto);
            return CreatedAtAction(nameof(GetById), new { id = created.id }, created);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(long id, InstitutionOpportunitiesCreatedDto dto)
        {
            var updated = await _service.UpdateAsync(id, dto);
            if (!updated) return NotFound();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(long id)
        {
            var deleted = await _service.DeleteAsync(id);
            if (!deleted) return NotFound();
            return NoContent();
        }
    }
}
