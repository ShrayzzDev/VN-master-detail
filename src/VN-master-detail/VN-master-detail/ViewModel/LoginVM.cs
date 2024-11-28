using CommunityToolkit.Mvvm.Input;
using Interfaces;
using SharedExtensions;
using System.Windows.Input;
using ViewModel;

namespace VN_master_detail.ViewModel
{
    public class LoginVM
    {
        private AppResourcesVM _resources;

        public string ApiKey { get; set; }

        public UserVM User { get; }

        private readonly Page _page;

        private readonly IUserPreferences _userPreferences;

        public ICommand Login { get; set; }

        public LoginVM(Page page,
                       UserVM user,
                       AppResourcesVM resources,
                       IUserPreferences userPreferences)
        {
            _page = page;
            User = user;
            _userPreferences = userPreferences;
            _resources = resources;
            InitCommand();
        }

        private void InitCommand()
        {
            Login = new AsyncRelayCommand(
                async () => {
                    // var usableKey = ApiKey.ToUsableKey();
                    if (await User.Login(ApiKey))
                    {
                        await _page.DisplayAlert(_resources.Success, _resources.YouAreConnected, _resources.Done);
                        _userPreferences.SetLoggedUser(ApiKey);
                        await Shell.Current.GoToAsync("//Home");
                        return;
                    }
                    await _page.DisplayAlert(_resources.Error, _resources.WrongCredentials, _resources.Done);
                }
            );
        }
    }
}
