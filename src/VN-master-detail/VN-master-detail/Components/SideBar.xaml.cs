using System.Diagnostics;

namespace VN_master_detail.Components;

public partial class SideBar : ContentView
{
	public SideBar()
	{
		InitializeComponent();
    }

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

    // NOTE : Both of these should be done to handle navigation 
    // in a proper way. Continuing like that, this will create 
    // pages on the stack, never removing previous ones.
    private async void AcceuilBtnClicked(object sender, EventArgs e)
    {
        if (AcceuilBtnColor.Equals(Colors.MediumPurple))
            await Navigation.PushAsync(new AcceuilPage());
    }

    private async void SearchBtnClicked(object sender, EventArgs e)
    {
        if (SearchBtnColor.Equals(Colors.MediumPurple))
            await Navigation.PushAsync(new Search());
    }

    private async void TestDetailBtn(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new NovelDetail("v1"));
    }
}