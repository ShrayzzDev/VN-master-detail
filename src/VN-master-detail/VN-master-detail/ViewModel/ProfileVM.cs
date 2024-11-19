using CommunityToolkit.Mvvm.Input;
using System.Windows.Input;
using ViewModel;

namespace VN_master_detail.ViewModel
{
    public class ProfileVM
    {
        public UserVM User { get; private set; }

        public NavigationVM Navigation { get; private init; }

        public ICommand Logout { get; set; }

        public ProfileVM(UserVM user, NavigationVM navigation)
        {
            User = user;
            Navigation = navigation;
            InitCommand();
        }

        private void InitCommand()
        {
            Logout = new AsyncRelayCommand(
                async () =>
                {
                    await User.Logout();
                    Navigation.GoToHome.Execute(null);
                }
            );
        }
    }
}
