﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ParserCookingRecipe.interpreter;
using ParserCookingRecipe.operation.complex;
using ParserCookingRecipe.operation.simple;

namespace ParserCookingRecipe.parser
{
    internal class NaryOperationCookingOrderHandler(string Token) : CookingRecipeTokenHandler(Token)
    {
        public override CookingOrder Handle(RecipeTree recipe)
        {
            throw new NotImplementedException();
        }
    }
}
