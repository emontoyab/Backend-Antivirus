using Microsoft.AspNetCore.Mvc;
using Antivirus.Models;
using Antivirus.Services;
using Antivirus.DTOs;
using Antivirus.Mappers;
using System.Security.Cryptography;
using System.Text;
using Antivirus.config;
using Antivirus.Data;

namespace Antivirus.Controllers
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

            // Verificar si el correo ya está registrado
            var existingUser = _context.users.FirstOrDefault(u => u.email == userDto.Email);
            if (existingUser != null)
            {
                return BadRequest(new { message = "El correo electrónico ya está registrado." });
            }

            // Agregar el usuario a la base de datos
            _context.users.Add(user);
            _context.SaveChanges();

            // Asignar el rol "user" automáticamente
            var defaultRole = _context.role.FirstOrDefault(r => r.name == "user");
            if (defaultRole != null)
            {
                var userRole = new user_roles
                {
                    users_id = user.id, // ID del usuario recién creado
                    role_id = defaultRole.id // ID del rol "user"
                };

                _context.user_roles.Add(userRole);
                _context.SaveChanges();
            }

            return Ok(new { message = "Usuario registrado exitosamente." });
        }

       [HttpPost("login")]
        public IActionResult Login([FromBody] LoginUserDto loginDto)
        {
            // Buscar el usuario por correo electrónico
            var existingUser = _context.users.FirstOrDefault(u => u.email == loginDto.Email);

            if (existingUser == null)
            {
                return Unauthorized(new { message = "Usuario no encontrado." });
            }

            // Verificar la contraseña encriptada
            string hashedPassword = PasswordHasher.HashPassword(loginDto.Password);

            if (existingUser.password != hashedPassword)
            {
                return Unauthorized(new { message = "Contraseña incorrecta." });
            }

            // Obtener el rol del usuario
            var userRole = _context.user_roles
                .Where(ur => ur.users_id == existingUser.id)
                .Select(ur => ur.role.name)
                .FirstOrDefault();

            if (userRole == null)
            {
                return Unauthorized(new { message = "El usuario no tiene un rol asignado." });
            }

            // Generar el token JWT
            var token = _authService.GenerateJwtToken(existingUser);

            // Configurar el token como una cookie HTTP-only
            Response.Cookies.Append("token", token, new CookieOptions
            {
                HttpOnly = true, // La cookie no es accesible desde JavaScript
                Secure = true, // Solo se envía en conexiones HTTPS
                SameSite = SameSiteMode.Lax, // Permite solicitudes del mismo sitio
                Path = "/", // Disponible en toda la aplicación
            });

            // Retornar el token y el rol en el cuerpo de la respuesta
            return Ok(new
            {
                message = "Inicio de sesión exitoso.",
                token = token,
                role = userRole // Incluir el rol en la respuesta
            });
        }

        [HttpPost("logout")]
        public IActionResult Logout()
        {
            // Eliminar la cookie del token
            Response.Cookies.Delete("token");

            return Ok(new { message = "Sesión cerrada exitosamente." });
        }
    }
}