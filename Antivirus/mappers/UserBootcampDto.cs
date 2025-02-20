using AutoMapper;
using Antivirus.Dtos;
using Antivirus.Models;
public class UsersBootcampsProfile : Profile
{
    public UsersBootcampsProfile()
    {
        CreateMap<users_bootcamps, UsersBootcampsDto>().ReverseMap();
        CreateMap<users_bootcamps, UsersBootcampsCreatedDto>().ReverseMap();
    }
}
