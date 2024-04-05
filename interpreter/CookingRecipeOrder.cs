using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ParserCookingRecipe.ingredient;
using ParserCookingRecipe.ingredient.basic;

namespace ParserCookingRecipe.interpreter
{
    internal class CookingRecipeOrder {
        public Ingredient Ingredient { get; set; }

        public CookingRecipeOrder()
        {
            Ingredient = new BasicIngredient("");
        }
    }
}
