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
        private CookingRecipeTokenChain() : base("Start") {
            this.AddNext(new IngredientCookingOrderHandler("Ingredient"));
            this.AddNext(new SimpleOperationCookingOrderHandler("SimpleOperation"));
            this.AddNext(new NaryOperationCookingOrderHandler("NaryOperation"));
            this.AddNext(new ErrorCookingOrderHandler("Error"));
        }

        public static CookingRecipeTokenChain Instance { get; } = new CookingRecipeTokenChain();

        public override CookingOrder Handle(RecipeTree recipe)
        {
            if (this.Next != null)
            {
                return this.Next.Handle(recipe);
            }
            throw new InvalidOperationException();
        }
    }
}
