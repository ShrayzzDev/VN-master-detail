using CommunityToolkit.Mvvm.ComponentModel;
using Model.Novel;
using Model;

namespace ViewModel.Novels
{
    public class BasicNovelVM : ObservableObject
    {
        internal BasicNovel? _novel;

        public string Id
        {
            get => _novel == null ? string.Empty : _novel.Id;   
        }

        public string Title
        {
            get => _novel == null ? string.Empty : _novel.Title;
        }

        public string Description
        {
            get => _novel == null ? string.Empty : _novel.Description;
        }

        public float Average
        {
            get => _novel == null ? 0 : _novel.Average;
        }

        public ImageVM Image
        {
            get => new ImageVM() { image = _novel == null ? new Image() : _novel.Image };
        }
    }
}
