using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Recipes.Domain.Table
{
    public class IngredientInfo
    {
        [Key]

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int RecipeId { get; set; }
        [ForeignKey(nameof(Ingredient))]
        public int IngredientId { get; set; }
        public Ingredient Ingredient { get; set; }

        public decimal Quantity
        {
            get; set;
        }
    }
}
