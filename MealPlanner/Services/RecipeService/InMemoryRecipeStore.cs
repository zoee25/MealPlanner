using System;
using System.Collections.Generic;
using MealPlanner.Models;

namespace MealPlanner.Services.RecipeService
{
    public class InMemoryRecipeStore : IRecipeStore
    {
        private List<IRecipeModel> _recipes;

        public static InMemoryRecipeStore Instance { get; set; } = new InMemoryRecipeStore();

        private InMemoryRecipeStore()
        {
            _recipes = new List<IRecipeModel>();
        }

        public bool AddRecipe(IRecipeModel recipe)
        {
            if (_recipes.Contains(recipe))
            {
                return false;
            }
            else
            {
                _recipes.Add(recipe);
                return true;
            }
        }

        public IEnumerable<IRecipeModel> GetRecipes()
        {
            return _recipes;
        }

        public bool RemoveRecipe(IRecipeModel recipe)
        {
            if(_recipes.Contains(recipe))
            {
                _recipes.Remove(recipe);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
