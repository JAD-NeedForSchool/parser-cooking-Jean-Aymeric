using ParserCookingRecipe.ingredient.basic;
using ParserCookingRecipe.interpreter;
using ParserCookingRecipe.operation.complex;
using ParserCookingRecipe.operation.simple;

CookingOrder TakeYellowOrder = new SimpleOperationCookingOrder(new SimpleOperation("PrendreJaune"), new IngredientCookingOrder(new BasicIngredient("Oeuf")));
CookingRecipeOrder context = new CookingRecipeOrder();



CookingOrder MixOrder = new NaryOperationCookingOrder(new NaryOperation("Mélanger"), [
        TakeYellowOrder,
        new IngredientCookingOrder(new BasicIngredient("Moutarde")),
        new IngredientCookingOrder(new BasicIngredient("Vinaigre")),
    ]);

CookingOrder AddOrder = new NaryOperationCookingOrder(new NaryOperation("Ajouter"), [
        MixOrder,
        new IngredientCookingOrder(new BasicIngredient("Huile")),
    ]);
CookingOrder MayonnaiseRecipe = new SimpleOperationCookingOrder(new SimpleOperation("Touiller"), AddOrder);

CookingRecipeOrder MayonnaiseOrder = new CookingRecipeOrder();

MayonnaiseRecipe.Interprete(MayonnaiseOrder);

Console.WriteLine(MayonnaiseOrder.Ingredient.Name);
