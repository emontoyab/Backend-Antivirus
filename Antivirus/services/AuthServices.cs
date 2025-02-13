using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Microsoft.IdentityModel.Tokens;
using Antivirus.Models;

namespace Antivirus.Services
{
 public class AuthService
 {
 private readonly IConfiguration _config;
 public AuthService(IConfiguration config) => _config = config;
 public string GenerateJwtToken(users user)
 {
 var claims = new[]
 {
 new Claim(ClaimTypes.Name, user.name),
 new Claim(ClaimTypes.Role, user.user_roles.First().role.ToString()),
 };
 var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Jwt:Key"]));
 var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
 var token = new JwtSecurityToken(
 _config["Jwt:Issuer"],
 _config["Jwt:Audience"],
 claims,
 expires: DateTime.UtcNow.AddHours(2),
 signingCredentials: creds
 );
 return new JwtSecurityTokenHandler().WriteToken(token);
 }
 }
}