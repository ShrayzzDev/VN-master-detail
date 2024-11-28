using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VN_master_detail.Resources.Localization;

namespace VN_master_detail.ViewModel
{
    public class AppResourcesVM : ObservableObject
    {
        public System.Globalization.CultureInfo Culture 
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

        public string Home => AppResources.Home;

        public string LogOut => AppResources.LogOut;

        public string Search => AppResources.Search;

        public string Username => AppResources.Username;
        public string Settings => AppResources.Settings;
    }
}
