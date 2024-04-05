using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ParserCookingRecipe.interpreter;

namespace ParserCookingRecipe.parser
{
    internal class CookingRecipeTokenChain : CookingRecipeTokenHandler
    {
        public CookingRecipeTokenChain() : base("START") { }

        public static CookingRecipeTokenChain Instance { get; } = new CookingRecipeTokenChain();

        public override CookingOrder? Handle(RecipeTree recipe)
        {
            if (this.Next != null)
            {
                return this.Next.Handle(recipe);
            }
            return null;
        }
    }
}
