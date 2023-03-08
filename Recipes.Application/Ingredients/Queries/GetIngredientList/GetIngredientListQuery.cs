using MediatR;
using Recipes.Domain.Dto.Ingredients;

namespace Recipes.Application.Ingredients.Queries.GetIngredientList
{
    public class GetIngredientListQuery : IRequest<IngredientInfoListDto>
    {

    }
}
