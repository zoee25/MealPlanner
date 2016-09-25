using Template10.Mvvm;

namespace MealPlanner.ViewModels
{
    public interface ISettingsPartViewModel
    {
        string LastVisited { get; }
        string BusyText { get; set; }
        DelegateCommand ShowBusyCommand { get; }
        bool UseLightThemeButton { get; set; }
        bool UseShellBackButton { get; set; }
    }
}