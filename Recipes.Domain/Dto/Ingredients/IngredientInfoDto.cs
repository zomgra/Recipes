namespace Recipes.Domain.Dto.Ingredients
{
    public class IngredientInfoDto
    {
        public int Id { get; set; }
        public int RecipeId { get; set; }
        public Ingredient Ingredient { get; set; }
        public decimal Quantity { get; set; }
    }
}
