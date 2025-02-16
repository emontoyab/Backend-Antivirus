using Microsoft.AspNetCore.Mvc;
using Antivirus.Dtos;
using Antivirus.Services;
using Antivirus.Models;
using Microsoft.AspNetCore.Authorization;

namespace Antivirus.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class StatusBootcampController : ControllerBase
    {
        private readonly IStatusBootcampService _statusBootcampService;
        public StatusBootcampController(IStatusBootcampService statusBootcampService)
        {
            _statusBootcampService = statusBootcampService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<StatusBootcampsDto>>> GetAll()
        {
            return Ok(await _statusBootcampService.GetAllAsync());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<StatusBootcampsDto>> Get(int id)
        {
            var status = await _statusBootcampService.GetByIdAsync(id);
            if (status == null)
                return NotFound();
            return Ok(status);
        }

        [HttpPost]
        public async Task<ActionResult> Create([FromBody] StatusBootcampsCreatedDto Dto)
        {
            await _statusBootcampService.CreateAsync(Dto);
            return CreatedAtAction(nameof(Get), Dto);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> Update(int id, [FromBody] StatusBootcampsCreatedDto Dto)
        {

            var existingStatus = await _statusBootcampService.GetByIdAsync(id);

            if (existingStatus == null)
                return NotFound();

            await _statusBootcampService.UpdateAsync(id, Dto);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var existingCost = await _statusBootcampService.GetByIdAsync(id);
            if (existingCost == null)
                return NotFound();
            await _statusBootcampService.DeleteAsync(id);
            return NoContent();
        }

    }

}