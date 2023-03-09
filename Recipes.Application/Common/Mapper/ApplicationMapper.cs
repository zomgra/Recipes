using AutoMapper;
using Recipes.Domain;
using Recipes.Domain.Dto.Ingredients;
using Recipes.Domain.Dto.Recipes;
using Recipes.Domain.Table;

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

            CreateMap<Recipe, RecipeInfoDto>()
                .ForMember(r => r.Id, d => d.MapFrom(i => i.Id))
                .ForMember(r => r.Name, d => d.MapFrom(i => i.Name))
                .ForMember(r => r.ImageUrl, d => d.MapFrom(i => i.ImageUrl))
                .ForMember(r => r.Instruction, d => d.MapFrom(i => i.Instruction))
                .ForMember(r => r.CreationTime, d => d.MapFrom(i => i.CreationTime))
                .ForMember(r => r.Description, d => d.MapFrom(i => i.Description));

            CreateMap<IngredientInfo, IngredientInfoDto>()
                .ForMember(d => d.Id, i => i.MapFrom(i => i.Id))
                .ForMember(d => d.Quantity, i => i.MapFrom(i => i.Quantity))
                .ForMember(d => d.Ingredient, i => i.MapFrom(i => i.Ingredient))
                .ForMember(d => d.RecipeId, i => i.MapFrom(i => i.RecipeId));
        }
    }
}
