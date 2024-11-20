using CommunityToolkit.Mvvm.ComponentModel;
using Model.Novel;
using Model;

namespace ViewModel.Novels
{
    public class BaseNovelVM : ObservableObject
    {
        internal BaseNovel? _novel;

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
            get
            {
                if (_novel == null) return 0;
                if (_novel is SimpleUserNovel userNovel) return userNovel.Vote == null ? 0 : userNovel.Vote.Value;
                return _novel.Average;
            }
        }

        public ImageVM Image
        {
            get => new() { image = _novel == null ? new Image() : _novel.Image };
        }
    }
}
