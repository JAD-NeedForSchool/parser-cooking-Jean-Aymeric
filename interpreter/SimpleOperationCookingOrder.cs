using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ParserCookingRecipe.ingredient.complex;
using ParserCookingRecipe.operation;

namespace ParserCookingRecipe.interpreter
{
    internal class SimpleOperationCookingOrder(Operation operation, CookingOrder cookingOrder) : CookingOrder
    {
        public Operation Operation { get; set; } = operation;
        public CookingOrder CookingOrder { get; set; } = cookingOrder;

        public void Interprete(CookingRecipeOrder context)
        {
            this.CookingOrder.Interprete(context);
            context.Ingredient = new ComplexIngredient(this.Operation.Name + "(" + context.Ingredient.Name + ")");
        }
    }
}
