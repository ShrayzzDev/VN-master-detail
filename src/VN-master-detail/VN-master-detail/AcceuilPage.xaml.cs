using DTO.Extensions;
using Interfaces;
using Model.Novel;
using Stub;
using System.Collections.ObjectModel;

namespace VN_master_detail
{
    public partial class AcceuilPage : ContentPage
    {
        private IDataManager manager = (App.Current as App).DataManager;

        public readonly ObservableCollection<BasicNovel?> Novels;

        public AcceuilPage()
        {
            InitializeComponent();
            var task = GetTest();
            Novels = new ObservableCollection<BasicNovel?>(task.Result);
            BindingContext = Novels;
        }

        private async Task<ObservableCollection<BasicNovel?>> GetTest()
        {
            var novel = await manager.GetNovelById("v1");
            var list = new ObservableCollection<BasicNovel?>() { novel };
            for (int i = 0; i < 100; ++i)
            {
                list.Add(novel);
            }
            return list;
        }
    }

}
