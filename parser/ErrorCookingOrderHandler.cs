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
    internal class ErrorCookingOrderHandler(string Token) : CookingRecipeTokenHandler(Token)
    {
        public override CookingOrder Handle(RecipeTree recipe)
        {
            throw new Exception("Error, Recipe tree impossible to transform.");
        }
    }
}
