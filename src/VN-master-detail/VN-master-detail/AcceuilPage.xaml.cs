using ViewModel;
using ViewModel.Novels;
using VN_master_detail.ViewModel;

namespace VN_master_detail
{
    public partial class AcceuilPage : ContentPage
    {
        public BaseNovelListVM Novels { get; private set; }

        public NavigationVM NavigationVM { get; set; }

        public UserVM User { get; set; }

        // We need to inject the theme so it initialize
        // and apply the themes, without needing to go to
        // the profile page.
        public AcceuilPage(BaseNovelListVM novels,
                           UserVM user,
                           ThemeVM theme)
        {
            Novels = novels;
            NavigationVM = new NavigationVM(user, Navigation);
            User = user;
            BindingContext = this;
            InitializeComponent();
        }
    }

}
