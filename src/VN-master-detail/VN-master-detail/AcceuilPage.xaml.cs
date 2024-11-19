using ViewModel;
using VN_master_detail.ViewModel;

namespace VN_master_detail
{
    public partial class AcceuilPage : ContentPage
    {
        public BasicNovelListVM Novels { get; private set; }

        public NavigationVM NavigationVM;

        public AcceuilPage(BasicNovelListVM novels,
                           UserVM user)
        {
            Novels = novels;
            NavigationVM = new NavigationVM(user);
            BindingContext = this;
            InitializeComponent();
        }
    }

}
