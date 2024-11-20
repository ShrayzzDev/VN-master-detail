using ViewModel.Novels;

namespace VN_master_detail;

public partial class NovelDetail : ContentPage
{
    public DetailedNovelVM Novel { get; set; }

    public string NovelId { get; private init; }

	public NovelDetail(string id, DetailedNovelVM novel)
    {
        Novel = novel;
        NovelId = id;
        InitializeComponent();
    }
}