namespace Recipes.Domain.Dto.Recipes
{
    public class RecipeInfoDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Instruction { get; set; }
        public string ImageUrl { get; set; }
        public DateTime CreationTime { get; set; }
    }
}
