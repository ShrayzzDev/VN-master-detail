using ViewModel;
using VN_master_detail.ViewModel;

namespace VN_master_detail;

public partial class Login : ContentPage
{
	public LoginVM LoginVM {  get; set; }

	public Login(UserVM user)
	{
		LoginVM = new LoginVM(this, user);
		InitializeComponent();
	}
}