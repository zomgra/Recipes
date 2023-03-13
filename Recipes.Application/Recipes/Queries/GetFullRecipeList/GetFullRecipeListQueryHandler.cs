using MediatR;
using Microsoft.EntityFrameworkCore;
using Recipes.Application.Interfaces;
using Recipes.Domain;

namespace Recipes.Application.Recipes.Queries.GetFullRecipeList
{
    public class GetFullRecipeListQueryHandler : IRequestHandler<GetFullRecipeListQuery, List<Recipe>>
    {
        private readonly IApplicationDbContext _context;

        public GetFullRecipeListQueryHandler(IApplicationDbContext context)
        {
            this._context = context;
        }
        public async Task<List<Recipe>> Handle(GetFullRecipeListQuery request, CancellationToken cancellationToken)
        {
            var entity = await _context.Recipes.Include(i => i.IngredientInfos).ThenInclude(i => i.Ingredient).ToListAsync();

            if (entity is null || !entity.Any())
                throw new Exception($"{nameof(entity)} is null or empty");

            return entity;
        }
    }
}
