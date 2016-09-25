namespace MealPlanner.ViewModels
{
    public interface ISettingsPageViewModel
    {
        AboutPartViewModel AboutPartViewModel { get; }
        ISettingsPartViewModel SettingsPartViewModel { get; }
    }
}