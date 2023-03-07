using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Recipes.Domain.Table;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Repices.Infrastructure.Persistance.Configurations
{
    public class IngredientInfoConfiguration : IEntityTypeConfiguration<IngredientInfo>
    {
        public void Configure(EntityTypeBuilder<IngredientInfo> builder)
        {
            builder
        .HasOne(ii => ii.Recipe)
        .WithMany(r => r.IngredientInfos)
        .HasForeignKey(ii => ii.RecipeId);

            builder
                .HasOne(ii => ii.Ingredient)
                .WithMany()
                .HasForeignKey(ii => ii.IngredientId);
        }
    }
    }

