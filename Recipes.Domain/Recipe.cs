using Recipes.Domain.Table;

namespace Recipes.Domain
{
    public class Recipe
    {
        public int Id { get; set; }
        //public Guid UserId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Instruction { get; set; }
        public string ImageUrl { get; set; }
        public string Category { get; set; }
        public DateTime CreationTime { get; set; }
        public virtual ICollection<IngredientInfo> IngredientInfos { get; set; }
    }
}
