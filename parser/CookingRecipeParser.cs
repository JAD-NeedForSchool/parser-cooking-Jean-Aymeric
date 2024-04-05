using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using ParserCookingRecipe.interpreter;

namespace ParserCookingRecipe.parser
{
    internal abstract class CookingRecipeParser
    {
        private static readonly char OpenCharacter = '(';
        private static readonly char CloseCharacter = ')';
        private static readonly char SeparatorCharacter = ' ';

        public static CookingOrder Parse(String recipeText)
        {
            throw new NotImplementedException();
        }

        public static RecipeTree TextToTree(String recipeText)
        {
            RecipeTree Root = new RecipeTree("");
            int OpenCount = 0;
            int CloseCount = 0;
            int LastSeparatorIndex = 0;
            for (int i = 0; (i < recipeText.Length) && (OpenCount + CloseCount >= 0); i++) {
                if (recipeText[i] == CookingRecipeParser.OpenCharacter) {
                    if (OpenCount == CloseCount) LastSeparatorIndex = i + 1;
                    OpenCount++;
                } else if (recipeText[i] == CookingRecipeParser.CloseCharacter) {
                    CloseCount++;
                    if(OpenCount == CloseCount) Root.AddSubRecipe(CookingRecipeParser.TextToTree(recipeText.Substring(LastSeparatorIndex, i - LastSeparatorIndex + 1)));
                } else if (recipeText[i] == CookingRecipeParser.SeparatorCharacter) {
                    if (OpenCount == (CloseCount + 1)) {
                        Root.AddSubRecipe(CookingRecipeParser.TextToTree(recipeText.Substring(LastSeparatorIndex, i - LastSeparatorIndex + 1)));
                        LastSeparatorIndex = i + 1;
                    }
                } else {
                    if (OpenCount == CloseCount) Root.Token += recipeText[i];
                }
            }
            return Root;
        }

        public static CookingOrder TreeToOrder(RecipeTree recipeTree)
        {
            throw new NotImplementedException();
        }
    }
}
