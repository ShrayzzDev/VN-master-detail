using ViewModel;

namespace VN_master_detail
{
    public partial class AcceuilPage : ContentPage
    {
        public BasicNovelListVM Novels { get; set; }

        public AcceuilPage(BasicNovelListVM novels)
        {
            Novels = novels;
            BindingContext = this;
            InitializeComponent();
        }
    }

}
