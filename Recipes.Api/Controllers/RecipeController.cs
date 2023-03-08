using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Recipes.Application.Interfaces;
using Recipes.Domain;
using Recipes.Domain.Dto.Recipes;
using Repices.Infrastructure.Persistance;

namespace Recipes.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RecipeController : ControllerBase
    {
        private readonly IApplicationDbContext context;

        public RecipeController(ApplicationDbContext context)
        {
            this.context = context;
        }
        /// <summary>
        /// Temporary function
        /// </summary>
        /// <returns>List of Full recipes</returns>
        [HttpGet("/full")]
        public async Task<List<Recipe>> GetFullRecipeList()
        {
            return await context.Recipes.Include(i=>i.IngredientInfos).ThenInclude(i=>i.Ingredient).ToListAsync();
        }
        [HttpGet]
        public async Task<List<RecipeSmallListDto>> GetAllSmallRecipes()
        {

        }
    }
}
