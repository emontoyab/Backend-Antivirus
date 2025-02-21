using Microsoft.AspNetCore.Mvc;
using Antivirus.Dtos;
using Antivirus.Services;
using Microsoft.AspNetCore.Authorization;

namespace Antivirus.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class UserRolesController : ControllerBase
    {
        private readonly IUserRolesService _userRolesService;

        public UserRolesController(IUserRolesService userRolesService)
        {
            _userRolesService = userRolesService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<UserRolesDto>>> GetAll()
        {
            return Ok(await _userRolesService.GetAllAsync());
        }

        [HttpGet("{usersId}/{roleId}")]
        public async Task<ActionResult<UserRolesDto>> Get(long usersId, long roleId)
        {
            var userRole = await _userRolesService.GetByIdAsync(usersId, roleId);
            if (userRole == null)
                return NotFound();
            return Ok(userRole);
        }

        [HttpPost]
        public async Task<ActionResult> Create([FromBody] UserRolesCreatedDto dto)
        {
            await _userRolesService.CreateAsync(dto);
            return CreatedAtAction(nameof(Get), new { usersId = dto.users_id, roleId = dto.role_id }, dto);
        }

        [HttpPut("{usersId}/{roleId}")]
        public async Task<ActionResult> Update(long usersId, long roleId, [FromBody] UserRolesCreatedDto dto)
        {
            var existingUserRole = await _userRolesService.GetByIdAsync(usersId, roleId);
            if (existingUserRole == null)
                return NotFound();

            await _userRolesService.UpdateAsync(usersId, roleId, dto);
            return NoContent();
        }

        [HttpDelete("{usersId}/{roleId}")]
        public async Task<ActionResult> Delete(long usersId, long roleId)
        {
            var existingUserRole = await _userRolesService.GetByIdAsync(usersId, roleId);
            if (existingUserRole == null)
                return NotFound();

            await _userRolesService.DeleteAsync(usersId, roleId);
            return NoContent();
        }
    }
}
