using Antivirus.DTOs;
using Antivirus.Models;
using Antivirus.config;

namespace Antivirus.Mappers
{
    public static class UserMapper
    {
        public static users MapRegisterUserDtoToUser(RegisterUserDto userDto)
        {
            return new users
            {
                name = userDto.Name,
                last_name = userDto.LastName,
                email = userDto.Email,
                password = PasswordHasher.HashPassword(userDto.Password),
                date_birth = userDto.DateBirth
            };
        }

        public static RegisterUserDto MapUserToRegisterUserDto(users user)
        {
            return new RegisterUserDto
            {
                Id = user.id,
                Name = user.name,
                LastName = user.last_name,
                Email = user.email,
                Password = user.password,
                DateBirth = user.date_birth
            };
        }
    }
}