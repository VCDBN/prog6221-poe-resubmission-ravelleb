using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeApp
{
    public class RecipeManager
    {
        private List<Recipe> recipes;

        public RecipeManager()
        {
            recipes = new List<Recipe>();
        }

        public void AddRecipe(Recipe recipe)
        {
            recipes.Add(recipe);
        }

        public List<Recipe> GetRecipes()
        {
            return recipes;
        }

        public List<Recipe> GetRecipesByIngredient(string ingredient)
        {
            List<Recipe> filteredRecipes = new List<Recipe>();
            foreach (Recipe recipe in recipes)
            {
                if (recipe.Ingredients.Exists(i => i.Name.Equals(ingredient, System.StringComparison.OrdinalIgnoreCase)))
                {
                    filteredRecipes.Add(recipe);
                }
            }
            return filteredRecipes;
        }

        public List<Recipe> GetRecipesByFoodGroup(string foodGroup)
        {
            List<Recipe> filteredRecipes = new List<Recipe>();
            foreach (Recipe recipe in recipes)
            {
                if (recipe.Ingredients.Exists(i => i.FoodGroup.Equals(foodGroup, System.StringComparison.OrdinalIgnoreCase)))
                {
                    filteredRecipes.Add(recipe);
                }
            }
            return filteredRecipes;
        }

        public List<Recipe> GetRecipesByMaxCalories(int maxCalories)
        {
            List<Recipe> filteredRecipes = new List<Recipe>();
            foreach (Recipe recipe in recipes)
            {
                int totalCalories = CalculateTotalCalories(recipe);
                if (totalCalories <= maxCalories)
                {
                    filteredRecipes.Add(recipe);
                }
            }
            return filteredRecipes;
        }

        public List<Recipe> GetRecipesByName(string recipeName)
        {
            return recipes.Where(recipe => recipe.Name.Equals(recipeName)).ToList();
        }

        private int CalculateTotalCalories(Recipe recipe)
        {
            int totalCalories = 0;
            foreach (Ingredient ingredient in recipe.Ingredients)
            {
                totalCalories += ingredient.Calories;
            }
            return totalCalories;
        }
    }
}