
using System;

// Ingredient class for each ingredient
class Ingredient
{
    public string Name { get; set; }
    public double Quantity { get; set; }
    public string Unit { get; set; }
}

// Step class to represent each step of the recipe
class RecipeStep
{
    public string Description { get; set; }
}

// Recipe class to represent the entire recipe
class Recipe
{
    private Ingredient[] ingredients;
    private RecipeStep[] steps;

    // Method to input the details for the recipe
    public void InputRecipeDetails()
    {
        Console.WriteLine("Enter the number of ingredients: ");
        int ingredientCount = int.Parse(Console.ReadLine());
        ingredients = new Ingredient[ingredientCount];

        for (int i = 0; i < ingredientCount; i++)
        {
            Console.WriteLine($"Enter the name of ingredient {i + 1}: ");
            string name = Console.ReadLine();

            Console.WriteLine($"Enter the quantity of {name}: ");
            double quantity = double.Parse(Console.ReadLine());

            Console.WriteLine($"Enter the unit of measurement for {name}: ");
            string unit = Console.ReadLine();

            ingredients[i] = new Ingredient { Name = name, Quantity = quantity, Unit = unit };
        }

        Console.WriteLine("Enter the number of steps: ");
        int stepCount = int.Parse(Console.ReadLine());
        steps = new RecipeStep[stepCount];

        for (int i = 0; i < stepCount; i++)
        {
            Console.WriteLine($"Enter step {i + 1}: ");
            string description = Console.ReadLine();
            steps[i] = new RecipeStep { Description = description };
        }
    }

    // Method to display the full recipe
    public void DisplayRecipe()
    {
        Console.WriteLine("Recipe:");
        Console.WriteLine("Ingredients:");
        foreach (var ingredient in ingredients)
        {
            Console.WriteLine($"{ingredient.Quantity} {ingredient.Unit} of {ingredient.Name}");
        }

        Console.WriteLine("Steps:");
        for (int i = 0; i < steps.Length; i++)
        {
            Console.WriteLine($"{i + 1}. {steps[i].Description}");
        }
    }

    // Method to scale the recipe by a factor
    public void ScaleRecipe(double factor)
    {
        foreach (var ingredient in ingredients)
        {
            ingredient.Quantity *= factor;
        }
    }

    // Method to reset the quantities to the original values
    public void ResetQuantities()
    {
        // Implement logic to reset quantities to original values
    }

    // Method to clear all data and enter a new recipe
    public void ClearRecipe()
    {
        // Implement logic to clear all data and enter a new recipe
    }
}

// Main program
class Program
{
    static void Main()
    {
        Recipe recipe = new Recipe();
        recipe.InputRecipeDetails();
        recipe.DisplayRecipe();

        // Additional logic for scaling, resetting, and clearing the recipe can be implemented here
    }
}
