using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ParserCookingRecipe.ingredient;
using ParserCookingRecipe.ingredient.complex;
using ParserCookingRecipe.operation;

namespace ParserCookingRecipe.interpreter
{
    internal class NaryOperationCookingOrder(Operation operation, List<CookingOrder> cookingOrders) : CookingOrder
    {
        public Operation Operation { get; set; } = operation;
        public List<CookingOrder> CookingOrders { get; set; } = cookingOrders;

        public void Interprete(CookingRecipeOrder context)
        {
            String subIngredients = "";
            foreach (CookingOrder order in this.CookingOrders) { 
                CookingRecipeOrder subContext = new CookingRecipeOrder();
                order.Interprete(subContext);
                subIngredients += subContext.Ingredient.Name + " ";
            }
            
            context.Ingredient = new ComplexIngredient(this.Operation.Name + "(" + subIngredients + ")");
        }
    }
}
