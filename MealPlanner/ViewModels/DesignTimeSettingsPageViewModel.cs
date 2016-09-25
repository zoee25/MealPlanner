using System;
using Template10.Mvvm;

namespace MealPlanner.ViewModels
{
    public class DesignTimeSettingsPageViewModel : ViewModelBase, ISettingsPageViewModel
    {
        public AboutPartViewModel AboutPartViewModel { get; set; }

        public ISettingsPartViewModel SettingsPartViewModel { get; set; } = new DesignTimeSettingsPartViewModel();
    }

    public class DesignTimeSettingsPartViewModel : ViewModelBase, ISettingsPartViewModel
    {
        public string BusyText { get; set; } = "Hello Designer!";

        public string LastVisited { get; set; } = DateTime.Now.ToString();

        public DelegateCommand ShowBusyCommand { get; set; }

        public bool UseLightThemeButton { get; set; } = true;

        public bool UseShellBackButton { get; set; }
    }
}
