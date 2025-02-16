// UserMapper.cs
using Antivirus.Dtos;
using Antivirus.Models;

namespace Antivirus.Mappers
{
    public static class UserMapper
    {
        public static users MapDtoToEntity(UserDto userDto)
        {
            return new users
            {
                id = userDto.Id,
                date_birth = userDto.DateBirth,
                email = userDto.Email,
                last_name = userDto.LastName,
                name = userDto.Name,
                password = userDto.Password,
                trial755 = userDto.Trial755
            };
        }

        public static UserDto MapEntityToDto(users user)
        {
            return new UserDto
            {
                Id = user.id,
                DateBirth = user.date_birth,
                Email = user.email,
                LastName = user.last_name,
                Name = user.name,
                Password = user.password,
                Trial755 = user.trial755
            };
        }

        public static IEnumerable<UserDto> MapEntitiesToDtos(IEnumerable<users> users)
        {
            return users.Select(MapEntityToDto).ToList();
        }
    }
}