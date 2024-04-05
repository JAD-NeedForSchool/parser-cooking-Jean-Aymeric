using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParserCookingRecipe.operation
{
    internal abstract class Operation {
        public String Name { get; set; }
        public Operation(String name) {
            this.Name = name;
        }
    }
}
