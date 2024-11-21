using ViewModel.Novels;

namespace VN_master_detail
{
    public partial class Search : ContentPage
    {
        public BaseNovelListVM Novels { get; set; }

        public Search(BaseNovelListVM novels)
        {
            Novels = novels;
            BindingContext = this;
            InitializeComponent();
        }
    }
}