using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using VN_master_detail.Resources.Localization;

namespace VN_master_detail.ViewModel
{
    public class AppResourcesVM : ObservableObject
    {
        private UserPreferences _preferences = new UserPreferences();

        public List<string> AvailableLangages { get; set; } =
        [
            "fr-FR",
            "en"
        ];

        public CultureInfo Culture 
        {
            get => AppResources.Culture;
            set
            {
                if (AppResources.Culture == value) return;
                AppResources.Culture = value;
                OnPropertyChanged(nameof(Culture));
                OnPropertyChanged(nameof(EnterAPIKey));
                OnPropertyChanged(nameof(Username));
                OnPropertyChanged(nameof(Settings));
                OnPropertyChanged(nameof(LogOut));
                OnPropertyChanged(nameof(Search));
                OnPropertyChanged(nameof(Login));
                OnPropertyChanged(nameof(Home));
            }
        }

        private string _culture;

        public string CurrentCulture 
        {
            get => _culture;
            set => SetProperty(ref _culture, value);
        }

        public ICommand ChangeCulture { get; private init; }

        public string Home => AppResources.Home;

        public string LogOut => AppResources.LogOut;

        public string Search => AppResources.Search;

        public string Username => AppResources.Username;

        public string Settings => AppResources.Settings;

        public string EnterAPIKey => AppResources.EnterAPIKey;

        public string Login => AppResources.Login;

        public AppResourcesVM()
        {
            CurrentCulture =_preferences.GetCulture();
            ChangeCulture = new RelayCommand(
                () =>
                {
                    Culture = CurrentCulture switch
                    {
                        "fr-FR" => new CultureInfo("fr-FR"),
                        "en" => new CultureInfo("en"),
                        _ => new CultureInfo("en")
                    };
                    _preferences.SetCulture(Culture.Name);
                }
            );
        }
    }
}
