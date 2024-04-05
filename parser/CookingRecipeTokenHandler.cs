using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ParserCookingRecipe.interpreter;

namespace ParserCookingRecipe.parser
{
    internal abstract class CookingRecipeTokenHandler(String Token, CookingRecipeTokenHandler? Next)
    {
        public string Token { get; set; } = Token;
        public CookingRecipeTokenHandler? Next { get; set; }

        public CookingRecipeTokenHandler(String token) : this(token, null) { }

        public bool HasNext() { return Next != null; }

        public abstract CookingOrder Handle(RecipeTree recipe);
        protected void AddNext(CookingRecipeTokenHandler next)
        {
            if (this.Next == null)
            {
                this.Next = next;
            }
            else
            {
                this.Next.AddNext(next);
            }
        }
    }
}
