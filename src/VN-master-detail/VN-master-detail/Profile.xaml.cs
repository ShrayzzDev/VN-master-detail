using ViewModel;
using VN_master_detail.ViewModel;

namespace VN_master_detail;

public partial class Profile : ContentPage
{
	public ProfileVM ProfileVM { get; private set; }

	public ThemeVM ThemeVM { get; private set; }

	public Profile(UserVM user, ThemeVM themeVm)
	{
		ProfileVM = new ProfileVM(user, new NavigationVM(user, Navigation));
		ThemeVM = themeVm;
		InitializeComponent();
	}
}