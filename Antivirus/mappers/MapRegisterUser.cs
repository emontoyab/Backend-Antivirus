using System.Security.Cryptography;
using System.Text;
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
            PasswordHash = Convert.ToBase64String(SHA256.Create().ComputeHash(Encoding.UTF8.GetBytes(userDto.Password))),
            date_birth = userDto.DateBirth
        };
    }
}
