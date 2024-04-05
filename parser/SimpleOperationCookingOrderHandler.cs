using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ParserCookingRecipe.ingredient.basic;
using ParserCookingRecipe.interpreter;
using ParserCookingRecipe.operation.simple;

namespace ParserCookingRecipe.parser
{
    internal class SimpleOperationCookingOrderHandler(string Token) : CookingRecipeTokenHandler(Token)
    {
        public override CookingOrder? Handle(RecipeTree recipe)
        {
            if (recipe.GetNbSubRecipes() == 1)
            {
                return new SimpleOperationCookingOrder(new SimpleOperation(recipe.Token), CookingRecipeParser.TreeToOrder(recipe.SubRecipeTrees[0]));
            }
            if (this.Next == null) { throw new Exception("No Next token"); }
            return this.Next.Handle(recipe);
        }
    }
}
