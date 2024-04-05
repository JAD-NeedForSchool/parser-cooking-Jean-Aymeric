using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParserCookingRecipe.operation
{
    internal abstract class Operation(String name)
    {
        public String Name { get; set; } = name;
    }
}
