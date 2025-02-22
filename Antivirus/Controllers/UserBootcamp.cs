using Microsoft.AspNetCore.Mvc;
using Antivirus.Dtos;
using Antivirus.Services;
using Microsoft.AspNetCore.Authorization;

namespace Antivirus.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class UsersBootcampsController : ControllerBase
    {
        private readonly IUsersBootcampsService _usersBootcampsService;

        public UsersBootcampsController(IUsersBootcampsService usersBootcampsService)
        {
            _usersBootcampsService = usersBootcampsService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<UsersBootcampsDto>>> GetAll()
        {
            return Ok(await _usersBootcampsService.GetAllAsync());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<UsersBootcampsDto>> GetById(long id)
        {
            var userBootcamp = await _usersBootcampsService.GetByIdAsync(id);
            if (userBootcamp == null)
                return NotFound();

            return Ok(userBootcamp);
        }

        [HttpPost]
        public async Task<ActionResult> Create([FromBody] UsersBootcampsCreatedDto dto)
        {
            var createdEntity = await _usersBootcampsService.CreateAsync(dto);
            return CreatedAtAction(nameof(GetById), new { id = createdEntity.id }, createdEntity);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> Update(long id, [FromBody] UsersBootcampsCreatedDto dto)
        {
            bool updated = await _usersBootcampsService.UpdateAsync(id, dto);
            if (!updated)
                return NotFound();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(long id)
        {
            bool deleted = await _usersBootcampsService.DeleteAsync(id);
            if (!deleted)
                return NotFound();

            return NoContent();
        }
    }
}
