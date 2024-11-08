using DTO.Extensions;
using Interfaces;
using Model.Novel;
using Stub;
using System.Collections.ObjectModel;

namespace VN_master_detail;

public partial class Search : ContentPage
{
    private IDataManager manager = (App.Current as App).DataManager;

    public readonly ObservableCollection<BasicNovel?> Novels;

    public Search()
	{
		InitializeComponent();
        Novels = new ObservableCollection<BasicNovel?>();
        BindingContext = Novels;
    }
}