using CommunityToolkit.Mvvm.Input;
using System.Windows.Input;
using ViewModel;
using ViewModel.Novels;

namespace VN_master_detail.ViewModel
{
    public class NavigationVM
    {
        private static UserVM _user;

        private INavigation _navigation;

        public ICommand GoToDetail { get; private set; }

        public ICommand GoToHome { get; private set; }

        public ICommand GoToSearch { get; private set; }

        public ICommand GoToLogin { get; private set; }

        public NavigationVM(UserVM? user, INavigation navigation)
        {
            if (user != null) _user = user;
            _navigation = navigation;
            InitCommand();
        }

        private void InitCommand()
        {
            GoToHome = new AsyncRelayCommand(
                async () => await Shell.Current.GoToAsync("//Home")
            );

            GoToSearch = new AsyncRelayCommand(
                async () => await Shell.Current.GoToAsync("//Search")
            );

            GoToLogin = new AsyncRelayCommand(
                async () =>
                {
                    if (!await _user.IsLoggedIn()) await Shell.Current.GoToAsync("//Login");
                    else await Shell.Current.GoToAsync("//Profile");
                }
            );

            GoToDetail = new AsyncRelayCommand<string>(
                async (id) => 
                {
                    if (id == null) return;
                    // I am very ashamed of that but i also am very tired of thinking this through.
                    await _navigation.PushAsync(new NovelDetail(id, new DetailedNovelVM(_user._dataManager)));
                }
            );
        }
    }
}
