using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ParserCookingRecipe.ingredient;
using ParserCookingRecipe.ingredient.basic;
using ParserCookingRecipe.interpreter;
using ParserCookingRecipe.operation.simple;

namespace ParserCookingRecipe.parser
{
    internal class IngredientCookingOrderHandler(string Token) : CookingRecipeTokenHandler(Token)
    {
        public override CookingOrder Handle(RecipeTree recipe)
        {
            if (recipe.GetNbSubRecipes() == 0) {
                return new IngredientCookingOrder(new BasicIngredient(recipe.Token));
            }
            if (this.Next == null) { throw new Exception("No Next token"); }
            return this.Next.Handle(recipe);
        }
    }
}
