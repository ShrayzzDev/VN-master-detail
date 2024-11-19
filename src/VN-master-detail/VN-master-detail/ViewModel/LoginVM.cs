using CommunityToolkit.Mvvm.Input;
using SharedExtensions;
using System.Windows.Input;
using ViewModel;

namespace VN_master_detail.ViewModel
{
    public class LoginVM
    {
        public string ApiKey { get; set; }

        public UserVM User { get; }

        private Page _page;

        public ICommand Login { get; set; }

        public LoginVM(Page page,
                       UserVM user)
        {
            _page = page;
            User = user;
            InitCommand();
        }

        private void InitCommand()
        {
            Login = new AsyncRelayCommand(
                async () => {
                    if (await User.Login(ApiKey.ToUsableKey()))
                    {
                        await _page.DisplayAlert("Success !", "You have been sucessfully conencted !", "Done");
                        await Shell.Current.GoToAsync("//Home") ;
                        return;
                    }
                    await _page.DisplayAlert("Error", "Credentials incorect, please retry.", "Ok");
                }
            );
        }
    }
}
