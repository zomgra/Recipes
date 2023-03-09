using MediatR;
using Recipes.Application.Interfaces;
using Recipes.Domain;

namespace Recipes.Application.Ingredients.Command.CreateIngredient
{
    public class CreateIngredientCommandHandler : IRequestHandler<CreateIngredientCommand>
    {
        private readonly IApplicationDbContext _context;

        public CreateIngredientCommandHandler(IApplicationDbContext context)
        {
            _context = context;
        }
        public async Task Handle(CreateIngredientCommand request, CancellationToken cancellationToken)
        {
            var ingredient = new Ingredient { Name = request.Name, Units = request.Units };
            await _context.Ingredients.AddAsync(ingredient, cancellationToken);

            await _context.SaveChangesAsync(cancellationToken);
        }
    }
}
