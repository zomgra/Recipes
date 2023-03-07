using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Recipes.Domain;

namespace Repices.Infrastructure.Persistance.Configurations
{
    public class RecipeConfiguration : IEntityTypeConfiguration<Recipe>
    {
        public void Configure(EntityTypeBuilder<Recipe> builder)
        {
            builder.Property(r => r.Id)
                .IsRequired();
            builder.HasMany(r => r.IngredientInfos)
                .WithMany();

        }
    }
}
