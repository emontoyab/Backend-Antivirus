using System.Collections.Generic;
using System.Threading.Tasks;
using Antivirus.Dtos;
using Antivirus.Services;
using Microsoft.AspNetCore.Mvc;

namespace Antivirus.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesOpportunitiesController : ControllerBase
    {
        private readonly ICategoriesOpportunitiesService _service;

        public CategoriesOpportunitiesController(ICategoriesOpportunitiesService service)
        {
            _service = service;
        }

        // GET: api/CategoriesOpportunities
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CategoriesOpportunitiesDTO>>> GetAll()
        {
            var list = await _service.GetAllAsync();
            return Ok(list);
        }

        // GET: api/CategoriesOpportunities/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CategoriesOpportunitiesDTO>> GetById(long id)
        {
            var dto = await _service.GetByIdAsync(id);
            if (dto == null)
            {
                return NotFound();
            }
            return Ok(dto);
        }

        // POST: api/CategoriesOpportunities
        [HttpPost]
        public async Task<ActionResult<CategoriesCreateOpportunitiesDTO>> Create(CategoriesCreateOpportunitiesDTO dto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var created = await _service.CreateAsync(dto);
            return CreatedAtAction(nameof(GetById), created);
        }

        // PUT: api/CategoriesOpportunities/5
        [HttpPut("{id}")]
        public async Task<ActionResult<CategoriesCreateOpportunitiesDTO>> Update(long id, CategoriesCreateOpportunitiesDTO dto)
        {
            var updated = await _service.UpdateAsync(id, dto);
            if (updated == null)
            {
                return NotFound();
            }
            return Ok(updated);
        }

        // DELETE: api/CategoriesOpportunities/5
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
