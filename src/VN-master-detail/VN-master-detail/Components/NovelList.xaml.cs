using CommunityToolkit.Mvvm.Input;
using NullInterfaces;
using System.Collections.ObjectModel;
using System.Windows.Input;
using ViewModel.Novels;
using VN_master_detail.ViewModel;

namespace VN_master_detail.Components;

public partial class NovelList : ContentView
{
	public static readonly BindableProperty NovelsProperty =
		BindableProperty.Create(nameof(Novels),
			typeof(ReadOnlyObservableCollection<BaseNovelVM>),
			typeof(NovelList),
			new ReadOnlyObservableCollection<BaseNovelVM>([])); 

	public ReadOnlyObservableCollection<BaseNovelVM> Novels
	{
		get => (ReadOnlyObservableCollection<BaseNovelVM>)GetValue(NovelsProperty);
		set => SetValue(NovelsProperty, value);
	}

	public NavigationVM NavigationVM { get; set; }

	public NovelList()
	{
		NavigationVM = new NavigationVM(null, Navigation);
		InitializeComponent();
	}
}