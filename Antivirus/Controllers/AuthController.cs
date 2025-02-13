using Microsoft.AspNetCore.Mvc;
using Antivirus.Models;
using Antivirus.Services;
using System.Security.Cryptography;
using System.Text;
namespace ProductApi.Controllers
{
    [Route("api/auth")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly AppDbContext _context;
        private readonly AuthService _authService;
        public AuthController(AppDbContext context, AuthService authService)
        {
            _context = context;
            _authService = authService;
        }

        [HttpPost("register")]
        public IActionResult Register([FromBody] RegisterUserDto userDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            // Mapear el DTO a la entidad users
            var user = UserMapper.MapRegisterUserDtoToUser(userDto);

            // Agregar el usuario a la base de datos
            _context.users.Add(user);
            _context.SaveChanges();

            return Ok(new { message = "Usuario registrado exitosamente." });
        }


        [HttpPost("login")]
        public IActionResult Login([FromBody] LoginUserDto loginDto)
        {
            var existingUser = _context.users.FirstOrDefault(u => u.email == loginDto.Email);

            if (existingUser == null)
            {
                return Unauthorized(new { message = "Usuario no encontrado." });
            }

            // Verificar la contraseña encriptada
            string hashedPassword = Convert.ToBase64String(SHA256.HashData(Encoding.UTF8.GetBytes(loginDto.Password)));

            if (existingUser.PasswordHash != hashedPassword)
            {
                return Unauthorized(new { message = "Contraseña incorrecta." });
            }

            var token = _authService.GenerateJwtToken(existingUser);
            return Ok(new { token });
        }

    }
}
