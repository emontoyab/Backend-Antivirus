using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using Antivirus.Dtos;
using Antivirus.Services;

namespace Antivirus.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RolesController : ControllerBase
    {
        private readonly IRoleService _roleService;

        public RolesController(IRoleService roleService)
        {
            _roleService = roleService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<RoleDto>>> GetAllRoles()
        {
            var roles = await _roleService.GetAllRolesAsync();
            return Ok(roles);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<RoleDto>> GetRoleById(long id)
        {
            try
            {
                var role = await _roleService.GetRoleByIdAsync(id);
                return Ok(role);
            }
            catch (KeyNotFoundException)
            {
                return NotFound();
            }
        }

        [HttpPost]
        public async Task<ActionResult<RoleDto>> CreateRole(RoleDto roleDto)
        {
            var createdRole = await _roleService.CreateRoleAsync(roleDto);
            return CreatedAtAction(nameof(GetRoleById), new { id = createdRole.Id }, createdRole);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<RoleDto>> UpdateRole(long id, RoleDto roleDto)
        {
            try
            {
                var updatedRole = await _roleService.UpdateRoleAsync(id, roleDto);
                return Ok(updatedRole);
            }
            catch (KeyNotFoundException)
            {
                return NotFound();
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteRole(long id)
        {
            try
            {
                await _roleService.DeleteRoleAsync(id);
                return NoContent();
            }
            catch (KeyNotFoundException)
            {
                return NotFound();
            }
        }
    }
}1