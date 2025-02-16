using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using Antivirus.Services;
using Antivirus.DTOs;
using Antivirus.Mappers;
using Antivirus.Models;
using Microsoft.EntityFrameworkCore;

namespace Antivirus.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TypeOpportunitiesController : ControllerBase
    {
        private readonly ITypeOpportunityService _typeOpportunityService;

        public TypeOpportunitiesController(ITypeOpportunityService typeOpportunityService)
        {
            _typeOpportunityService = typeOpportunityService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<TypeOpportunityResponseDto>>> GetAll()
        {
            return Ok(await _typeOpportunityService.GetAllAsync());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<TypeOpportunityResponseDto>> GetById(long id)
        {
            var opportunity = await _typeOpportunityService.GetByIdAsync(id);
            if (opportunity == null)
                return NotFound();
            return Ok(opportunity);
        }

        [HttpPost]
        public async Task<ActionResult> Create(TypeOpportunityRequestDto opportunityDto)
        {
            var createdOpportunity = await _typeOpportunityService.CreateAsync(opportunityDto);
            return CreatedAtAction(nameof(GetById), new { id = createdOpportunity.Id }, createdOpportunity);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(long id, TypeOpportunityRequestDto opportunityDto)
        {
            var updated = await _typeOpportunityService.UpdateAsync(id, opportunityDto);
            if (!updated) return NotFound();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(long id)
        {
            var deleted = await _typeOpportunityService.DeleteAsync(id);
            if (!deleted) return NotFound();
            return NoContent();
        }
    }
}
