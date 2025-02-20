using Antivirus.DTOs;
using Antivirus.Services;
using Microsoft.AspNetCore.Mvc;


namespace Antivirus.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserOpportunitiesController : ControllerBase
    {
        private readonly IUserOpportunitiesService _service;

        public UserOpportunitiesController(IUserOpportunitiesService service)
        {
            _service = service;
        }

        // GET: api/UserOpportunities
        [HttpGet]
        public async Task<ActionResult<IEnumerable<UserOpportunitiesResponseDto>>> GetAll()
        {
            var result = await _service.GetAllAsync();
            return Ok(result);
        }

        // GET: api/UserOpportunities/{id}
        [HttpGet("{id}")]
        public async Task<ActionResult<UserOpportunitiesResponseDto>> GetById(long id)
        {
            var result = await _service.GetByIdAsync(id);
            if (result == null)
            {
                return NotFound();
            }
            return Ok(result);
        }

        // POST: api/UserOpportunities
        [HttpPost]
        public async Task<ActionResult<UserOpportunitiesResponseDto>> Create(UserOpportunitiesRequestDto dto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var created = await _service.CreateAsync(dto);
            return CreatedAtAction(nameof(GetById), new { id = created.id }, created);
        }

        // PUT: api/UserOpportunities/{id}
        [HttpPut("{id}")]
        public async Task<ActionResult<UserOpportunitiesResponseDto>> Update(long id, UserOpportunitiesRequestDto dto)
        {
            var updated = await _service.UpdateAsync(id, dto);
            if (updated == null)
            {
                return NotFound();
            }
            return Ok(updated);
        }

        // DELETE: api/UserOpportunities/{id}
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
