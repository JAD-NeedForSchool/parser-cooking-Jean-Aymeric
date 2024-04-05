namespace ParserCookingRecipe.parser
{
    public class RecipeTree(String Token)
    {
        public String Token { get; set; } = Token;
        public List<RecipeTree> SubRecipeTrees { get; } = [];

        public void AddSubRecipe(RecipeTree RecipeTree)
        {
            this.SubRecipeTrees.Add(RecipeTree);
        }
    }
}