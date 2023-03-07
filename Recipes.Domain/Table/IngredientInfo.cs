﻿namespace Recipes.Domain.Table
{
    public class IngredientInfo
    {
        public int Id { get; set; }

        public int RecipeId { get; set; }
        public Recipe Recipe { get; set; }

        public int IngredientId { get; set; }
        public Ingredient Ingredient { get; set; }

        public decimal Quantity
        {
            get; set;
        }
    }
}
