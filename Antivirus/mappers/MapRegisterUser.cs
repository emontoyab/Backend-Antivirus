using System.Security.Cryptography;
using System.Text;
using Antivirus.config;
using Antivirus.Models;

public class UserMapper
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
}
