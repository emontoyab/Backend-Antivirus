using AutoMapper;
using Antivirus.Models;
using Antivirus.DTOs;

namespace Antivirus.Mappers
{
    public class UserOpportunitiesProfile : Profile
    {
        public UserOpportunitiesProfile()
        {
            // Mapeo para la respuesta: se incluye el id
            CreateMap<user_oportunities, UserOpportunitiesResponseDto>();

            // Mapeo para la solicitud: se ignoran el id, trial755 y la navegación a otras entidades
            CreateMap<UserOpportunitiesRequestDto, user_oportunities>()
                .ForMember(dest => dest.id, opt => opt.Ignore())
                .ForMember(dest => dest.trial755, opt => opt.Ignore())
                .ForMember(dest => dest.id_opportunityNavigation, opt => opt.Ignore())
                .ForMember(dest => dest.id_userNavigation, opt => opt.Ignore());
        }
    }
}
