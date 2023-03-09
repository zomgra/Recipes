using Microsoft.AspNetCore.Mvc;
using Recipes.Application.Ingredients.Command.CreateIngredient;
using Recipes.Application.Ingredients.Queries.GetIngredientList;
using Recipes.Domain.Dto.Ingredients;

namespace Recipes.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IngredientController : BaseApiController
    {
        [HttpGet]
        public async Task<ActionResult<IngredientInfoListDto>> GetAllIngredients()
        {
            var query = new GetIngredientListQuery();
            return await Mediator.Send(query);
        }
        [HttpPost]
        public async Task<ActionResult> CreateIngredient([FromBody] CreateIngredientCommand command)
        {
            await Mediator.Send(command);
            return Ok();
        }
    }
}
