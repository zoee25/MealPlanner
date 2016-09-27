using System;

namespace MealPlanner.Models
{
    public interface IRecipeModel
    {
          string RecipeName { get; }
          DateTimeOffset Date { get; }
          string Location { get;  }
          string Ingredients { get; }
    }
}