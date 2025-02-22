using Antivirus.DTOs;
using Antivirus.Services;
using Microsoft.AspNetCore.Mvc;

namespace Antivirus.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TopicsBootcampsController : ControllerBase
    {
        private readonly ITopicsBootcampsService _service;

        public TopicsBootcampsController(ITopicsBootcampsService service)
        {
            _service = service;
        }

        // GET: api/TopicsBootcamps
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TopicsBootcampsResponseDto>>> GetAll()
        {
            var topics = await _service.GetAllAsync();
            return Ok(topics);
        }

        // GET: api/TopicsBootcamps/{id}
        [HttpGet("{id}")]
        public async Task<ActionResult<TopicsBootcampsResponseDto>> GetById(long id)
        {
            var topic = await _service.GetByIdAsync(id);
            if (topic == null)
            {
                return NotFound();
            }
            return Ok(topic);
        }

        // POST: api/TopicsBootcamps
        [HttpPost]
        public async Task<ActionResult<TopicsBootcampsResponseDto>> Create(TopicsBootcampsRequestDto dto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var createdTopic = await _service.CreateAsync(dto);
            return CreatedAtAction(nameof(GetById), new { id = createdTopic.id }, createdTopic);
        }

        // PUT: api/TopicsBootcamps/{id}
        [HttpPut("{id}")]
        public async Task<ActionResult<TopicsBootcampsResponseDto>> Update(long id, TopicsBootcampsRequestDto dto)
        {
            var updatedTopic = await _service.UpdateAsync(id, dto);
            if (updatedTopic == null)
            {
                return NotFound();
            }
            return Ok(updatedTopic);
        }

        // DELETE: api/TopicsBootcamps/{id}
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
