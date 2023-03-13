using MediatR;
using Recipes.Domain;

namespace Recipes.Application.Recipes.Queries.GetFullRecipeList
{
    public class GetFullRecipeListQuery : IRequest<List<Recipe>>
    {

    }
}
