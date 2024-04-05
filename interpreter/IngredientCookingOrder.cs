using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ParserCookingRecipe.ingredient;

namespace ParserCookingRecipe.interpreter
{
    internal class IngredientCookingOrder : CookingOrder
    {
        public Ingredient Ingredient {  get; set; }

        public IngredientCookingOrder(Ingredient ingredient)
        {
            Ingredient = ingredient;
        }

        void CookingOrder.Interprete(CookingRecipeOrder context)
        {
            context.Ingredient = this.Ingredient;
        }
    }
}
