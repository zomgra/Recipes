using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Recipes.Domain.Table;
using System.Reflection.Emit;

namespace Repices.Infrastructure.Persistance.Configurations
{
    public class IngredientInfoConfiguration : IEntityTypeConfiguration<IngredientInfo>
    {
        public void Configure(EntityTypeBuilder<IngredientInfo> builder)
        {
            builder
            .HasKey(i => i.Id);

            builder
                .HasOne(ii => ii.Ingredient)
                .WithMany()
                .HasForeignKey(ii => ii.IngredientId);
        }
    }
}

