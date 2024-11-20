using ViewModel.Novels;

namespace VN_master_detail
{
    public partial class Search : ContentPage
    {
        public BasicNovelListVM Novels { get; set; }

        public Search(BasicNovelListVM novels)
        {
            Novels = novels;
            BindingContext = this;
            InitializeComponent();
        }
    }
}