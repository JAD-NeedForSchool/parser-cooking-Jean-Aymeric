using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ParserCookingRecipe.ingredient;
using ParserCookingRecipe.interpreter;
using ParserCookingRecipe.operation.simple;

namespace ParserCookingRecipe.parser
{
    internal class IngredientCookingOrderHandler(string Token, Ingredient Ingredient) : CookingRecipeTokenHandler(Token)
    {
        public Ingredient Ingredient { get; set; } = Ingredient;

        public override CookingOrder? Handle(RecipeTree recipe)
        {
            throw new NotImplementedException();
        }
    }
}
