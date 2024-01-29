using System;


(int TypeRecip, int Ingredient, int Season) Recipe;

Console.WriteLine($"[Types]: \n1) {Type.Soup} \n2) {Type.Stew} \n3) {Type.Gumbo}");
Console.WriteLine($"\n[Ingredients]: \n1) {MainIngredient.Mushrooms} \n2) {MainIngredient.Chicken} \n3) {MainIngredient.Carrots} \n4) {MainIngredient.Potatoes}");
Console.WriteLine($"\n[Seasoning]: \n1) {Seasoning.Spicy} \n2) {Seasoning.Salty} \n3){Seasoning.Sweet}");
  
Console.Write("\n");

Console.Write(" * What kind of recipe do you want do cook? ");
Recipe.TypeRecip = Convert.ToInt32(Console.ReadLine());

Console.Write(" * What kind of ingredient do you want do put in your recipe? ");
Recipe.Ingredient = Convert.ToInt32(Console.ReadLine());

Console.Write(" * What kind of seasoning do you want to put in your recipe? ");
Recipe.Season = Convert.ToInt32(Console.ReadLine());

//==================================== // ====================-============ // 

Console.WriteLine($"\nYour recipe is: {(Seasoning)Recipe.Season} {(MainIngredient)Recipe.Ingredient} {(Type) Recipe.TypeRecip}");




enum Type {Soup = 1, Stew = 2, Gumbo = 3};
enum MainIngredient {Mushrooms = 1, Chicken = 2, Carrots = 3, Potatoes = 4};
enum Seasoning {Spicy = 1, Salty = 2, Sweet = 3};
