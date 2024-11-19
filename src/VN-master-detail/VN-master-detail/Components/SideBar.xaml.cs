using System.Diagnostics;
using VN_master_detail.ViewModel;

namespace VN_master_detail.Components;

public partial class SideBar : ContentView
{
    public NavigationVM NavigationVM { get; private set; } = new();

    public static readonly BindableProperty SearchBtnColorProperty =
        BindableProperty.Create(nameof(SearchBtnColor), typeof(Color), typeof(SideBar), Colors.MediumPurple);

    public Color SearchBtnColor
    {
        get => (Color)GetValue(SearchBtnColorProperty);
        set => SetValue(SearchBtnColorProperty, value);
    }

    public static readonly BindableProperty AcceuilBtnColorProperty =
        BindableProperty.Create(nameof(AcceuilBtnColor), typeof(Color), typeof(SideBar), Colors.MediumPurple);

    public Color AcceuilBtnColor
    {
        get => (Color)GetValue(AcceuilBtnColorProperty);
        set => SetValue(AcceuilBtnColorProperty, value);
    }
    public SideBar()
	{
		InitializeComponent();
    }
}