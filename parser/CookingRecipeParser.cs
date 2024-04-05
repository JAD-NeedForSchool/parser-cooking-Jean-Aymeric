using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using ParserCookingRecipe.interpreter;

namespace ParserCookingRecipe.parser
{
    internal abstract class CookingRecipeParser {
        private const char OpenCharacter = '(';
        private const char CloseCharacter = ')';
        private const char SeparatorCharacter = ' ';

        public static CookingOrder Parse(String recipeText) {
            return CookingRecipeParser.TreeToOrder(CookingRecipeParser.TextToTree(recipeText));
        }

        internal static RecipeTree TextToTree(String recipeText) {
            RecipeTree Root = new RecipeTree("");
            int OpenCount = 0;
            int CloseCount = 0;
            int LastSeparatorIndex = 0;

            for (int i = 0; (i < recipeText.Length) && (OpenCount + CloseCount >= 0); i++) {
                switch (recipeText[i]) {
                    case CookingRecipeParser.OpenCharacter:
                        if (OpenCount == CloseCount) LastSeparatorIndex = i + 1;
                        OpenCount++;
                        break;
                    case CookingRecipeParser.CloseCharacter:
                        CloseCount++;
                        if (OpenCount == CloseCount) Root.AddSubRecipe(CookingRecipeParser.TextToTree(recipeText.Substring(LastSeparatorIndex, i - LastSeparatorIndex + 1)));
                        break;
                    case CookingRecipeParser.SeparatorCharacter:
                        if (OpenCount == (CloseCount + 1)) {
                            Root.AddSubRecipe(CookingRecipeParser.TextToTree(recipeText.Substring(LastSeparatorIndex, i - LastSeparatorIndex + 1)));
                            LastSeparatorIndex = i + 1;
                        }
                        break;
                    default:
                        if (OpenCount == CloseCount) Root.Token += recipeText[i];
                        break;
                }
            }
            return Root;
        }

        internal static CookingOrder TreeToOrder(RecipeTree recipeTree) {
            return CookingRecipeTokenChain.Instance.Handle(recipeTree);
        }
    }
}
