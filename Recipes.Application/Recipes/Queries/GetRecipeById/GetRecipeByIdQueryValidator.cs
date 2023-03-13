using FluentValidation;

namespace Recipes.Application.Recipes.Queries.GetRecipeById
{
    public class GetRecipeByIdQueryValidator : AbstractValidator<GetRecipeByIdQuery>
    {
        public GetRecipeByIdQueryValidator()
        {
            RuleFor(x => x.Id).NotNull();
        }
    }
}
