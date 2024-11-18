using DTO.Extensions;
using Interfaces;
using Model.Novel;
using Stub;
using System.Collections.ObjectModel;
using ViewModel;

namespace VN_master_detail
{
    public partial class AcceuilPage : ContentPage
    {
        public BasicNovelListVM Novels { get; set; }
        public AcceuilPage(BasicNovelListVM list)
        {
            InitializeComponent();
            Novels = list;
            Novels.GetNovels.Execute(null);
            BindingContext = Novels;
        }
    }

}
