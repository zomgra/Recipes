using Microsoft.EntityFrameworkCore;
using Recipes.Domain;
using Recipes.Domain.Table;

namespace Recipes.Application.Interfaces
{
    public interface IApplicationDbContext
    {
        DbSet<Recipe> Recipes { get; set; }
        DbSet<Ingredient> Ingredients { get; set; }
        DbSet<IngredientInfo> IngredientInfos { get; set; }
        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
