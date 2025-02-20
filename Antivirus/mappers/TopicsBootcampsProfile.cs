using AutoMapper;
using Antivirus.Models;
using Antivirus.DTOs;

namespace Antivirus.Mappers
{
    public class TopicsBootcampsProfile : Profile
    {
        public TopicsBootcampsProfile()
        {
            // Para obtener la información completa (respuesta)
            CreateMap<topics_bootcamps, TopicsBootcampsResponseDto>();

            // Para crear o actualizar, no se mapea el id (ya que se genera automáticamente)
            CreateMap<TopicsBootcampsRequestDto, topics_bootcamps>()
                .ForMember(dest => dest.id, opt => opt.Ignore())
                .ForMember(dest => dest.trial751, opt => opt.Ignore())
                .ForMember(dest => dest.bootcamps, opt => opt.Ignore());
        }
    }
}
