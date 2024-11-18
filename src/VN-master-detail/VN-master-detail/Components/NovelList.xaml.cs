using NullInterfaces;
using System.Collections.ObjectModel;
using ViewModel;

namespace VN_master_detail.Components;

public partial class NovelList : ContentView
{
	public static readonly BindableProperty NovelsProperty =
		BindableProperty.Create(nameof(Novels),
			typeof(ReadOnlyObservableCollection<BasicNovelVM>),
			typeof(NovelList),
			new ReadOnlyObservableCollection<BasicNovelVM>([])); 

	public ReadOnlyObservableCollection<BasicNovelVM> Novels
	{
		get => (ReadOnlyObservableCollection<BasicNovelVM>)GetValue(NovelsProperty);
		set => SetValue(NovelsProperty, value);
	}

	public NovelList()
	{
		InitializeComponent();
	}
}