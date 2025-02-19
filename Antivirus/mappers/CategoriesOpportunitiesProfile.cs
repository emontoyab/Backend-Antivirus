using AutoMapper;
using Antivirus.Models;
using Antivirus.Dtos;

namespace Antivirus.Profiles
{
    public class CategoriesOpportunitiesProfile : Profile
    {
        public CategoriesOpportunitiesProfile()
        {
            CreateMap<categories_opportunities, CategoriesOpportunitiesDTO>().ReverseMap();
            CreateMap<categories_opportunities, CategoriesCreateOpportunitiesDTO>().ReverseMap();
        }
    }
}
