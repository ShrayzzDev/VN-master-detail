using Interfaces;
using Model.Novel;
using System.Diagnostics;

namespace VN_master_detail;

public partial class NovelDetail : ContentPage
{
	public static readonly BindableProperty NovelProperty =
		BindableProperty.Create(nameof(novel), typeof(DetailedNovel), typeof(NovelDetail), new DetailedNovel());
	
	public DetailedNovel novel
	{
		get => (DetailedNovel)GetValue(NovelProperty);
		set => SetValue(NovelProperty, value);
	}

	public static readonly BindableProperty ImagesProperty =
		BindableProperty.Create(nameof(images), typeof(List<Model.Image>), typeof(NovelDetail), new List<Model.Image>());

	/// <summary>
	/// Needed to bind to all images,
	/// including screenshots and main images
	/// </summary>
	public List<Model.Image> images
	{
		get => (List<Model.Image>)GetValue(ImagesProperty);
		set => SetValue(ImagesProperty, value);
	}

	public NovelDetail(string id)
    {
		if (novel.Image != null)
			images.Add(novel.Image);
		// TEST
		images.Add(new Model.Image("2", "dotnet_bot.png", new int[] { 50, 50 }, 0, 0, 10, "thumbnail", new int[] {0, 0}));
        // TEST
        images = [.. images.OrderBy(i => i.votecount)];
        InitializeComponent();
    }
}