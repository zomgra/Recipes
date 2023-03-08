using Recipes.Domain;
using Recipes.Domain.Table;
using System.Reflection;

namespace Repices.Infrastructure.Persistance
{
    public class ApplicationDbContextSeed
    {
        public static void Initialize(ApplicationDbContext context)
        {
            context.Database.EnsureCreated();

            var egg = new Ingredient { Name = "Egg", Units = "stuck" };
            var milk = new Ingredient { Name = "Milk", Units = "ml" };
            var myka = new Ingredient { Name = "Myka", Units = "gramm" };

            var recipes = new Recipe[]
            {
    new Recipe
    {
        Name = "Борщ",
        CreationTime = DateTime.Now,
        Description = "Лучшее блюдо Украины",
        IngredientInfos = new List<IngredientInfo>
        {
            new IngredientInfo { Ingredient = egg, Quantity = 3 },
            new IngredientInfo { Ingredient = myka, Quantity = 100 }
        },
        Instruction = "1) blablabla",
        ImageUrl = "https://cdn.lifehacker.ru/wp-content/uploads/2014/12/ob-05_1568611223.jpg"
    },
    new Recipe
    {
        Name = "Пюреха",
        CreationTime = DateTime.UtcNow,
        Description = "Под котлетки что надо",
        Instruction = "Bla bla ",
        ImageUrl = "https://cdn.lifehacker.ru/wp-content/uploads/2020/04/22_1588178346-e1588178427412.jpg",
        IngredientInfos = new List<IngredientInfo>
        {
            new IngredientInfo { Ingredient = egg, Quantity = 1000 },
            new IngredientInfo { Ingredient = milk, Quantity = 2000 },
            new IngredientInfo { Ingredient = myka, Quantity = 40 },
            new IngredientInfo { Ingredient = myka, Quantity = 666 }
        }
    }
            };

            if (!context.Ingredients.Any())
            {
                context.Ingredients.AddRange(new[] { egg, milk, myka });
                context.SaveChanges();
            }

            if (!context.Recipes.Any())
            {
                context.AddRange(recipes);
                context.SaveChanges();
            }

        }
    }
}
