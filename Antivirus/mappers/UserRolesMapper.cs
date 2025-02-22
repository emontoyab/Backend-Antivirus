using AutoMapper;
using Antivirus.Dtos;
using Antivirus.Models;

namespace Antivirus.Mappers
{
    public class UserRolesProfile : Profile
    {
        public UserRolesProfile()
        {
            CreateMap<user_roles, UserRolesDto>();
            CreateMap<UserRolesCreatedDto, user_roles>();
        }
    }
}
