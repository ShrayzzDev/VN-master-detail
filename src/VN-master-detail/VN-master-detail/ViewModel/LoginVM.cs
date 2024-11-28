using CommunityToolkit.Mvvm.Input;
using Interfaces;
using SharedExtensions;
using System.Windows.Input;
using ViewModel;

namespace VN_master_detail.ViewModel
{
    public class LoginVM
    {
        public string ApiKey { get; set; }

        public UserVM User { get; }

        private readonly Page _page;

        private readonly IUserPreferences _userPreferences;

        public ICommand Login { get; set; }

        public LoginVM(Page page,
                       UserVM user,
                       IUserPreferences userPreferences)
        {
            _page = page;
            User = user;
            _userPreferences = userPreferences;
            InitCommand();
        }

        private void InitCommand()
        {
            Login = new AsyncRelayCommand(
                async () => {
                    var usableKey = ApiKey.ToUsableKey();
                    if (await User.Login(usableKey))
                    {
                        await _page.DisplayAlert("Success !", "You have been sucessfully conencted !", "Done");
                        _userPreferences.SetLoggedUser(usableKey);
                        await Shell.Current.GoToAsync("//Home");
                        return;
                    }
                    await _page.DisplayAlert("Error", "Credentials incorect, please retry.", "Ok");
                }
            );
        }
    }
}
