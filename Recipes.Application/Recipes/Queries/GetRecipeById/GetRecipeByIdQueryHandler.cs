using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Recipes.Application.Interfaces;
using Recipes.Domain.Dto.Recipes;

namespace Recipes.Application.Recipes.Queries.GetRecipeById
{
    public class GetRecipeByIdQueryHandler : IRequestHandler<GetRecipeByIdQuery, RecipeInfoDto>
    {
        private readonly IApplicationDbContext _context;
        private readonly IMapper _mapper;

        public GetRecipeByIdQueryHandler(IApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<RecipeInfoDto> Handle(GetRecipeByIdQuery request, CancellationToken cancellationToken)
        {
            var entity = await _context.Recipes.Include(i=>i.IngredientInfos).ThenInclude(i=>i.Ingredient).FirstOrDefaultAsync(r => r.Id == request.Id);

            if (entity == null) throw new Exception($"{nameof(entity)} is null");
            var recipe = _mapper.Map<RecipeInfoDto>(entity);

            return recipe;
        }
    }
}
