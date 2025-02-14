using Antivirus.DTOs;
using Antivirus.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Antivirus.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StatusOpportunitiesController : ControllerBase
    {
        private readonly IStatusOpportunitiesService _service;

        public StatusOpportunitiesController(IStatusOpportunitiesService service)
        {
            _service = service;
        }

        // GET: api/StatusOpportunities
        [HttpGet]
        public async Task<ActionResult<IEnumerable<StatusOpportunitiesDTO>>> GetAll()
        {
            var statuses = await _service.GetAllAsync();
            return Ok(statuses);
        }

        // GET: api/StatusOpportunities/{id}
        [HttpGet("{id}")]
        public async Task<ActionResult<StatusOpportunitiesDTO>> GetById(long id)
        {
            var statusDto = await _service.GetByIdAsync(id);
            if (statusDto == null)
            {
                return NotFound();
            }
            return Ok(statusDto);
        }

        // POST: api/StatusOpportunities
        [HttpPost]
        public async Task<ActionResult<StatusOpportunitiesDTO>> Create(StatusOpportunitiesDTO dto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var createdStatus = await _service.CreateAsync(dto);
            return CreatedAtAction(nameof(GetById), new { id = createdStatus.id }, createdStatus);
        }

        // PUT: api/StatusOpportunities/{id}
        [HttpPut("{id}")]
        public async Task<ActionResult<StatusOpportunitiesDTO>> Update(long id, StatusOpportunitiesDTO dto)
        {
            if (id != dto.id)
            {
                return BadRequest("El ID del recurso no coincide con el ID de la petición.");
            }
            var updatedStatus = await _service.UpdateAsync(id, dto);
            if (updatedStatus == null)
            {
                return NotFound();
            }
            return Ok(updatedStatus);
        }

        // DELETE: api/StatusOpportunities/{id}
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
