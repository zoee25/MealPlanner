using System;
using MealPlanner.Services.RecipeService;
using Template10.Mvvm;
using Windows.UI.Xaml;
using MealPlanner.Models;

namespace MealPlanner.ViewModels
{
    public class AddRecipeViewModel : ViewModelBase, IAddRecipeViewModel
    {
        private readonly IRecipeStore _recipeStore;
        private string _recipeName;
        private DateTimeOffset _recipeDate;
        private string _location;
        private string _ingredients;

        public AddRecipeViewModel()
        {
            _recipeStore = InMemoryRecipeStore.Instance;
            _recipeName = string.Empty;
            _recipeDate = DateTimeOffset.Now;
            _location = string.Empty;
            _ingredients = string.Empty;
        }

        public string RecipeName
        {
            get { return _recipeName; }
            set { Set(ref _recipeName, value); }
        }

        public DateTimeOffset Date
        {
            get { return _recipeDate; }
            set { Set(ref _recipeDate, value); }
        }

        public string Location
        {
            get { return _location; }
            set { Set(ref _location, value); }
        }

        public string Ingredients
        {
            get { return _ingredients; }
            set { Set(ref _ingredients, value); }
        }

        public void AddRecipe(object sender, RoutedEventArgs e)
        {
            IRecipeModel newRecipe = new RecipeModel(
                this.RecipeName,
                this.Date,
                this.Location,
                this.Ingredients);

            _recipeStore.AddRecipe(newRecipe);
        }
    }
}
      




