using System;

namespace MealPlanner.Models
{

    public class RecipeModel : IRecipeModel
    {
        private readonly string _recipeName;
        private readonly DateTimeOffset _recipeDate;
        private readonly string _location;
        private readonly string _ingredients;

        public RecipeModel(
            string recipeName,
            DateTimeOffset date,
            string location,
            string ingridents)
        {
            _recipeName = recipeName;
            _recipeDate = date;
            _location = location;
            _ingredients = ingridents;
        }

        public string RecipeName
        {
            get { return _recipeName; }
        }

        public DateTimeOffset Date
        {
            get { return _recipeDate; }
        }

        public string Location
        {
            get { return _location; }
        }

        public string Ingredients
        {
            get { return _ingredients; }
        }

        public override bool Equals(object obj)
        {
            RecipeModel other = obj as RecipeModel;

            if (other == null)
            {
                return false;
            }

            return this.RecipeName == other.RecipeName &&
                this.Location == other.Location &&
                this.Ingredients == other.Ingredients &&
                this.Date.DayOfYear == other.Date.DayOfYear &&
                this.Date.Year == other.Date.Year;
        }

        public override int GetHashCode()
        {
            int baseHash = base.GetHashCode();

            baseHash ^= this.RecipeName.GetHashCode();
            baseHash ^= this.Location.GetHashCode();
            baseHash ^= this.Ingredients.GetHashCode();
            baseHash ^= this.Date.GetHashCode();

            return baseHash;
        }
    }
}

