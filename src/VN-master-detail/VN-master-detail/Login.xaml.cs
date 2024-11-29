using Interfaces;
using ViewModel;
using VN_master_detail.ViewModel;

namespace VN_master_detail;

public partial class Login : ContentPage
{
	public LoginVM LoginVM { get; set; }

	public Login(UserVM user,
				 AppResourcesVM appResourcesVM,
				 IUserPreferences userPreferences)
	{
		LoginVM = new LoginVM(this, user, appResourcesVM, userPreferences);
		InitializeComponent();
	}
}