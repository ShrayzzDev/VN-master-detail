using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;
using System.Windows.Input;
using VN_master_detail.Resources.Themes;

namespace VN_master_detail.ViewModel
{
    public class ThemeVM : ObservableObject
    {
        public ICommand ChangeTheme { get; set; }

        private readonly List<string> _themes =
        [
            "Light",
            "Dark"
        ];

        public readonly ReadOnlyCollection<string> Themes;

        private string _theme;

        public string CurrentTheme
        {
            get => _theme;
            set => SetProperty(ref _theme, value);
        }

        public ThemeVM() 
        {
            Themes = new(_themes);
            CurrentTheme = Preferences.Get("theme", "Light");
            SetTheme(CurrentTheme);
            InitCommand();
        }

        private void SetTheme(string? theme)
        {
            if (theme == "System") theme = Application.Current.RequestedTheme.ToString();
            ResourceDictionary chosenTheme = theme switch
            {
                "Light" => new LightTheme(),
                "Dark" => new DarkTheme(),
                _ => throw new NotImplementedException()
            };

            var mergedDictionaries = Application.Current?.Resources.MergedDictionaries;
            if (mergedDictionaries != null)
            {
                foreach(var dico in mergedDictionaries.Where(d => d is ICustomTheme))
                {
                    mergedDictionaries.Remove(dico);
                }
                mergedDictionaries.Add(chosenTheme);
            }
        }

        private void InitCommand()
        {
            ChangeTheme = new RelayCommand(
            () =>
            {
                if (CurrentTheme == null) return;
                SetTheme(CurrentTheme);
                Preferences.Set("theme", CurrentTheme);
            });
        }
    }
}
