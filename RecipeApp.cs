using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeApp
{
    public class RecipeApp
    {
        private RecipeManager recipeManager;

        public RecipeApp()
        {
            recipeManager = new RecipeManager();
        }

        public void AddRecipe(Recipe recipe)
        {
            recipeManager.AddRecipe(recipe);
        }

        // Additional methods for managing recipes and filters can be added here
    }
}