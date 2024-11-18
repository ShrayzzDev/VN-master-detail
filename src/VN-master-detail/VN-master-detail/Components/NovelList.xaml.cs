using NullInterfaces;
using ViewModel;

namespace VN_master_detail.Components;

public partial class NovelList : ContentView
{
	public static readonly BindableProperty NovelsProperty =
		BindableProperty.Create(nameof(Novels),
			typeof(BasicNovelListVM),
			typeof(NovelList),
			new BasicNovelListVM(new NullDataManager())); 

	public BasicNovelListVM Novels
	{
		get => (BasicNovelListVM)GetValue(NovelsProperty);
		set => SetValue(NovelsProperty, value);
	}

	public NovelList()
	{
		InitializeComponent();
	}
}