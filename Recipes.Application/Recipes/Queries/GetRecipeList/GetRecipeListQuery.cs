using MediatR;
using Recipes.Domain.Dto.Recipes;

namespace Recipes.Application.Recipes.Queries.GetRecipeList
{
    public class GetRecipeListQuery : IRequest<RecipeSmallListDto>
    {

    }
}
