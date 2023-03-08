using AutoMapper;
using AutoMapper.QueryableExtensions;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Recipes.Application.Interfaces;
using Recipes.Domain.Dto.Recipes;

namespace Recipes.Application.Recipes.Queries.GetRecipeList
{
    public class GetRecipeListQueryHandler : IRequestHandler<GetRecipeListQuery, RecipeSmallListDto>
    {
        private readonly IApplicationDbContext _context;
        private readonly IMapper _mapper;

        public GetRecipeListQueryHandler(IApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<RecipeSmallListDto> Handle(GetRecipeListQuery request, CancellationToken cancellationToken)
        {
            var entity = _context.Recipes.Include(i => i.IngredientInfos).ProjectTo<RecipeSmallDto>(_mapper.ConfigurationProvider);
            if (entity == null || !entity.Any()) throw new Exception($"{entity} is empty or null");
            return new RecipeSmallListDto() { Recipes = await entity.ToListAsync(cancellationToken) };

        }
    }
}
