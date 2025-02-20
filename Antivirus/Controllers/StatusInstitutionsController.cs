using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using Antivirus.Services;
using Antivirus.DTOs;
using Antivirus.Mappers;
using Antivirus.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;

namespace Antivirus.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Authorize]
    public class StatusInstitutionsController : ControllerBase
    {
        private readonly IStatusInstitutionService _statusInstitutionService;

        public StatusInstitutionsController(IStatusInstitutionService statusInstitutionService)
        {
            _statusInstitutionService = statusInstitutionService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<StatusInstitutionResponseDto>>> GetAll()
        {
            return Ok(await _statusInstitutionService.GetAllAsync());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<StatusInstitutionResponseDto>> GetById(long id)
        {
            var status = await _statusInstitutionService.GetByIdAsync(id);
            if (status == null)
                return NotFound();
            return Ok(status);
        }

        [HttpPost]
        public async Task<ActionResult> Create(StatusInstitutionRequestDto statusDto)
        {
            var createdStatus = await _statusInstitutionService.CreateAsync(statusDto);
            return CreatedAtAction(nameof(GetById), new { id = createdStatus.Id }, createdStatus);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(long id, StatusInstitutionRequestDto statusDto)
        {
            var updated = await _statusInstitutionService.UpdateAsync(id, statusDto);
            if (!updated) return NotFound();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(long id)
        {
            var deleted = await _statusInstitutionService.DeleteAsync(id);
            if (!deleted) return NotFound();
            return NoContent();
        }
    }
}
