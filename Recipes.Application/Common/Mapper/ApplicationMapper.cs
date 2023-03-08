using AutoMapper;
using Recipes.Domain;
using Recipes.Domain.Dto.Recipes;

namespace Recipes.Application.Common.Mapper
{
    public class ApplicationMapper : Profile
    {
        public ApplicationMapper()
        {
            CreateMap<Recipe, RecipeSmallDto>()
                .ForMember(r => r.Id, d => d.MapFrom(s => s.Id))
                .ForMember(r => r.Name, d => d.MapFrom(s => s.Name))
                .ForMember(r => r.ImageUrl, d => d.MapFrom(s => s.ImageUrl))
                .ForMember(r => r.CreationTime, d => d.MapFrom(s => s.CreationTime));

        }
    }
}
