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
        public CultureInfo Culture 
        {
            get => AppResources.Culture;
            set
            {
                if (AppResources.Culture == value) return;
                AppResources.Culture = value;
                OnPropertyChanged(nameof(Culture));
                OnPropertyChanged(nameof(Username));
                OnPropertyChanged(nameof(Settings));
                OnPropertyChanged(nameof(LogOut));
                OnPropertyChanged(nameof(Search));
                OnPropertyChanged(nameof(Home));
            }
        }

        public string CurrentCulture { get; set; }

        public ICommand ChangeCulture { get; private init; }

        public string Home => AppResources.Home;

        public string LogOut => AppResources.LogOut;

        public string Search => AppResources.Search;

        public string Username => AppResources.Username;
        public string Settings => AppResources.Settings;

        public AppResourcesVM()
        {
            CurrentCulture = CultureInfo.CurrentUICulture.Name;
            ChangeCulture = new RelayCommand(
                () =>
                {
                    Culture = CurrentCulture switch
                    {
                        "fr-FR" => new CultureInfo("fr-FR"),
                        "en" => new CultureInfo("en"),
                        _ => new CultureInfo("en")
                    };
                    Debug.Print("a");
                }
            );
        }
    }
}
