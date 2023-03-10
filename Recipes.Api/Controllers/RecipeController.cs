using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Recipes.Application.Interfaces;
using Recipes.Application.Recipes.Queries.GetRecipeById;
using Recipes.Application.Recipes.Queries.GetRecipeList;
using Recipes.Domain;
using Recipes.Domain.Dto.Recipes;
using Repices.Infrastructure.Persistance;

namespace Recipes.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RecipeController : BaseApiController
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
        [HttpGet("full")]
        public async Task<List<Recipe>> GetFullRecipeList()
        {
            return await context.Recipes.Include(i=>i.IngredientInfos).ThenInclude(i=>i.Ingredient).ToListAsync();
        }
        [HttpGet]
        public async Task<ActionResult<RecipeSmallListDto>> GetAllSmallRecipes()
        {
            var query = new GetRecipeListQuery();
            var result = await Mediator.Send(query);
            return Ok(result);
        }
        [HttpGet("{id:int}")]
        public async Task<ActionResult<RecipeInfoDto>> GetRecipeById(int id)
        {
            var query = new GetRecipeByIdQuery() { Id = id };
            var result = await Mediator.Send(query);
            return Ok(result);
        }
    }
}
