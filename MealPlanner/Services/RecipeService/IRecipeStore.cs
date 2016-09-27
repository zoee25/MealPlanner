using MealPlanner.Models;
using System.Collections.Generic;

namespace MealPlanner.Services.RecipeService
{
    public interface IRecipeStore
    {
        /// <summary>
        /// Adds a recipe to the recipe store
        /// </summary>
        /// <param name="recipe">The recipe to add</param>
        /// <returns>Whether the recipe was successfully added to the recipe store</returns>
        bool AddRecipe(IRecipeModel recipe);
        bool RemoveRecipe(IRecipeModel recipe);
        IEnumerable<IRecipeModel> GetRecipes();
    }
}

