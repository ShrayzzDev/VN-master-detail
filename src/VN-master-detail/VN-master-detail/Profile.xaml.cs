using ViewModel;
using VN_master_detail.ViewModel;

namespace VN_master_detail;

public partial class Profile : ContentPage
{
	public ProfileVM ProfileVM { get; set; }

	public Profile(UserVM user)
	{
		ProfileVM = new ProfileVM(user, new NavigationVM(user, Navigation));
		InitializeComponent();
	}
}