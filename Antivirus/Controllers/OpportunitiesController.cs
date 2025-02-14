using Antivirus.DTOs;
using Antivirus.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Antivirus.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OpportunitiesController : ControllerBase
    {
        private readonly IOpportunitiesService _service;

        public OpportunitiesController(IOpportunitiesService service)
        {
            _service = service;
        }

        // GET: api/Opportunities
        [HttpGet]
        public async Task<ActionResult<IEnumerable<OpportunitiesDTO>>> GetAll()
        {
            var opportunities = await _service.GetAllAsync();
            return Ok(opportunities);
        }

        // GET: api/Opportunities/{id}
        [HttpGet("{id}")]
        public async Task<ActionResult<OpportunitiesDTO>> GetById(long id)
        {
            var opportunity = await _service.GetByIdAsync(id);
            if (opportunity == null)
            {
                return NotFound();
            }
            return Ok(opportunity);
        }

        // POST: api/Opportunities
        [HttpPost]
        public async Task<ActionResult<OpportunitiesDTO>> Create(OpportunitiesDTO dto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var createdOpportunity = await _service.CreateAsync(dto);
            return CreatedAtAction(nameof(GetById), new { id = createdOpportunity.id }, createdOpportunity);
        }

        // PUT: api/Opportunities/{id}
        [HttpPut("{id}")]
        public async Task<ActionResult<OpportunitiesDTO>> Update(long id, OpportunitiesDTO dto)
        {
            if (id != dto.id)
            {
                return BadRequest("El ID del recurso no coincide con el ID de la petición.");
            }
            var updatedOpportunity = await _service.UpdateAsync(id, dto);
            if (updatedOpportunity == null)
            {
                return NotFound();
            }
            return Ok(updatedOpportunity);
        }

        // DELETE: api/Opportunities/{id}
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(long id)
        {
            var result = await _service.DeleteAsync(id);
            if (!result)
            {
                return NotFound();
            }
            return NoContent();
        }
    }
}
