using MediatR;

namespace Recipes.Application.Ingredients.Command.CreateIngredient
{
    public class CreateIngredientCommand : IRequest
    {
        public string Name { get; set; }
        public string Units { get; set; }
    }
}
