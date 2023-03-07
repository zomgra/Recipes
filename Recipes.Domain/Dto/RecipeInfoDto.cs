using Recipes.Domain.Table;

namespace Recipes.Domain.Dto
{
    public class RecipeInfoDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Instruction { get; set; }
        public string ImageUrl { get; set; }
        public string Category { get; set; }
        public DateTime CreationTime { get; set; }
    }
}
