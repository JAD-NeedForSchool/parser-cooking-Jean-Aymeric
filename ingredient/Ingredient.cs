using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParserCookingRecipe.ingredient
{
    internal abstract class Ingredient(String name)
    {
        public String Name { get; set; } = name;
    }
}
