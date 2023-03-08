using MediatR;
using Recipes.Domain.Dto.Recipes;

namespace Recipes.Application.Recipes.Queries.GetRecipeById
{
    public class GetRecipeByIdQuery : IRequest<RecipeInfoDto>
    {
        public int Id { get; set; }
    }
}
