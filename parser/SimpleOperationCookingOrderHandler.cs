using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ParserCookingRecipe.interpreter;
using ParserCookingRecipe.operation.simple;

namespace ParserCookingRecipe.parser
{
    internal class SimpleOperationCookingOrderHandler(string Token, SimpleOperation Operation) : CookingRecipeTokenHandler(Token)
    {
        public SimpleOperation Operation { get; set; } = Operation;
        public override CookingOrder? Handle(RecipeTree recipe)
        {
            throw new NotImplementedException();
        }
    }
}
