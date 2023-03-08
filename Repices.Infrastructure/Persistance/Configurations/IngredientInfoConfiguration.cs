using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Recipes.Domain.Table;

namespace Repices.Infrastructure.Persistance.Configurations
{
    public class IngredientInfoConfiguration : IEntityTypeConfiguration<IngredientInfo>
    {
        public void Configure(EntityTypeBuilder<IngredientInfo> builder)
        {
            
        }
    }
}

