using System.ComponentModel.DataAnnotations;

namespace Recipes.Domain.Table
{
    public class RecipeIngredient
    {
        [Key]
        public int Id { get; set; }
        public int RecipeId { get; set; }
        public int IngredientId { get; set; }
        public Ingredient Ingredient { get; set; }
        public int Weight { get; set; }
    }
}
