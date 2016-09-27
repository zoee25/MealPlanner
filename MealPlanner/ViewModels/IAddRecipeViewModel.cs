using System;

namespace MealPlanner.ViewModels
{
    public interface IAddRecipeViewModel
    {
        string RecipeName { get; set; }
        DateTimeOffset Date { get; set; }
        string Location { get; set; }
        string Ingredients { get; set; }

        void AddRecipe(object sender, Windows.UI.Xaml.RoutedEventArgs e);
    }
}