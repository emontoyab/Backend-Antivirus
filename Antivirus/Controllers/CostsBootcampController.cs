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
    public class CostsBootcampController : ControllerBase
    {
        private readonly ICostsBootcampService _costsBootcampService;
        public CostsBootcampController(ICostsBootcampService costsBootcampService)
        {
            _costsBootcampService = costsBootcampService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<CostBootcampsDto>>> GetAll()
        {
            return Ok(await _costsBootcampService.GetAllAsync());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<CostBootcampsDto>> Get(int id)
        {
            var costs = await _costsBootcampService.GetByIdAsync(id);
            if (costs == null)
                return NotFound();
            return Ok(costs);
        }

        [HttpPost]
        public async Task<ActionResult> Create([FromBody] CostBootcampsDto costBootcampsDto)
        {
            await _costsBootcampService.CreateAsync(costBootcampsDto);
            return CreatedAtAction(nameof(Get),costBootcampsDto);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> Update(int id, [FromBody] CostBootcampsDto costBootcampsDto)
        {
            var existingCost = await _costsBootcampService.GetByIdAsync(id);

            if (existingCost == null)
                return NotFound();
            
            await _costsBootcampService.UpdateAsync(id,costBootcampsDto);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var existingCost = await _costsBootcampService.GetByIdAsync(id);
            if(existingCost == null)
                return NotFound();
            await _costsBootcampService.DeleteAsync(id);
            return NoContent();
        }

    }
    
}