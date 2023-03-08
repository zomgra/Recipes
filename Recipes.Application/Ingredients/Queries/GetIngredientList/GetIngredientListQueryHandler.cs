using AutoMapper;
using AutoMapper.QueryableExtensions;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Recipes.Application.Interfaces;
using Recipes.Domain.Dto.Ingredients;

namespace Recipes.Application.Ingredients.Queries.GetIngredientList
{
    public class GetIngredientListQueryHandler : IRequestHandler<GetIngredientListQuery, IngredientInfoListDto>
    {
        private readonly IMapper _mapper;
        private readonly IApplicationDbContext _context;

        public GetIngredientListQueryHandler(IMapper mapper, IApplicationDbContext context)
        {
            this._mapper = mapper;
            this._context = context;
        }
        public async Task<IngredientInfoListDto> Handle(GetIngredientListQuery request, CancellationToken cancellationToken)
        {
            var entity = _context.IngredientInfos.Include(i=>i.Ingredient);
            if (entity == null || !entity.Any()) throw new Exception($"{nameof(entity)} is null or empty");
            var dto = await entity.ProjectTo<IngredientInfoDto>(_mapper.ConfigurationProvider).ToListAsync();
            return new IngredientInfoListDto { Ingredients = dto };

        }
    }
}
