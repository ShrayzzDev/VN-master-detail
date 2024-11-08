using Model.Novel;
using System.Collections.ObjectModel;

namespace VN_master_detail.Components;

public partial class NovelList : ContentView
{
	public static readonly BindableProperty NovelsProperty =
		BindableProperty.Create(nameof(Novels),
			typeof(ObservableCollection<BasicNovel>),
			typeof(NovelList),
			new ObservableCollection<BasicNovel>()); 

	public ObservableCollection<BasicNovel> Novels
	{
		get => (ObservableCollection<BasicNovel>)GetValue(NovelsProperty);
		set => SetValue(NovelsProperty, value);
	}

	public NovelList()
	{
		InitializeComponent();
	}

    private void GameImageClicked(object sender, EventArgs e)
    {
    }
}