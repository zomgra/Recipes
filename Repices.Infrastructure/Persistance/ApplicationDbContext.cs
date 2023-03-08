using Microsoft.EntityFrameworkCore;
using Recipes.Application.Interfaces;
using Recipes.Domain;
using Recipes.Domain.Table;

namespace Repices.Infrastructure.Persistance
{
    public class ApplicationDbContext : DbContext, IApplicationDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Recipe> Recipes { get; set; }
        public DbSet<Ingredient> Ingredients { get; set; }
        public DbSet<IngredientInfo> IngredientInfos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Ingredient>()
                .HasKey(x => x.Id);

            modelBuilder.Entity<IngredientInfo>()
                .HasKey(i => i.Id);

            modelBuilder.Entity<IngredientInfo>()
                .HasOne(ii => ii.Ingredient)
                .WithMany()
                .HasForeignKey(ii => ii.IngredientId);

            base.OnModelCreating(modelBuilder);
        }
    }
}
