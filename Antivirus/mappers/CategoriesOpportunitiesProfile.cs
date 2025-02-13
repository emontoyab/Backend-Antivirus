using AutoMapper;
using Antivirus.Models;
using Antivirus.DTOs;

namespace Antivirus.Profiles
{
    public class CategoriesOpportunitiesProfile : Profile
    {
        public CategoriesOpportunitiesProfile()
        {
            CreateMap<categories_opportunities, CategoriesOpportunitiesDTO>().ReverseMap();
        }
    }
}
