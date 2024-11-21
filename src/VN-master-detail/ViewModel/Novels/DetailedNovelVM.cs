using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Interfaces;
using Model;
using Model.Novel;
using Model.Producer;
using Model.Title;
using System.Diagnostics;
using System.Windows.Input;

namespace ViewModel.Novels
{
    public class DetailedNovelVM : ObservableObject
    {
        private readonly IDataManager<User> _dataManager;

        private DetailedNovel _novel = new();

        private bool _isUserConnected;

        public bool IsUserConnected 
        {
            get => _isUserConnected;
            private set => SetProperty(ref _isUserConnected, value);
        }

        private bool _isInUserList;

        public bool IsInUserList 
        {
            get => _isInUserList;
            private set => SetProperty(ref _isInUserList, value);
        }

        public DetailedNovel Novel
        {
            get => _novel;
            set
            {
                SetProperty(ref _novel, value);
                OnPropertyChanged(nameof(Title));
                OnPropertyChanged(nameof(Titles));
                OnPropertyChanged(nameof(Developpers));
                OnPropertyChanged(nameof(Aliases));
                OnPropertyChanged(nameof(Description));
                OnPropertyChanged(nameof(DevStatus));
                OnPropertyChanged(nameof(Platforms));
                OnPropertyChanged(nameof(Languages));
                OnPropertyChanged(nameof(Image));
            }
        }

        public string Title
        {
            get => _novel.Title;
            set => SetProperty(_novel.Title, value, callback: (value) => { Novel.Title = value; });
        }

        public List<SimpleTitleVM> Titles
        {
            get
            {
                var model = _novel.Titles;
                var titles = new List<SimpleTitleVM>(model.Count);
                model.ForEach((elem) => titles.Add(new SimpleTitleVM() { simpleTitle = elem }));
                return titles;
            }
        }

        public SimpleProducerVM[] Developpers
        {
            get
            {
                var model = _novel.Developpers;
                var devs = new SimpleProducerVM[model.Length];
                for (int i = 0; i < model.Length; ++i)
                {
                    devs[i] = new SimpleProducerVM() { _producer = model[i] };
                }
                return devs;
            }
        }

        public string[] Aliases
        {
            get => _novel.aliases;
        }

        public string Description
        {
            get => _novel.Description;
        }

        public DevStatusEnum DevStatus
        {
            get => _novel.devstatus;
        }

        public string[] Platforms
        {
            get => _novel.platforms;
        }

        public string[] Languages
        {
            get => _novel.languages;
        }

        public ImageVM Image
        {
            get => new() { image = _novel.Image };
        }

        public ICommand RetrieveNovel { get; private set; }

        public ICommand AddNovelToUser { get; private set; }

        public ICommand DeleteNovelFromUser { get; private set; }

        public DetailedNovelVM(IDataManager<User> dataManager)
        {
            _dataManager = dataManager;
            InitCommand();
        }

        private void InitCommand()
        {
            RetrieveNovel = new AsyncRelayCommand<string>(
                async (id) =>
                {
                    if (id == null) return;
                    var retrieved = await _dataManager.GetDetailedNovelById(id);
                    if (retrieved == null) return;
                    IsUserConnected = await _dataManager.IsLoggedIn();
                    IsInUserList = await _dataManager.DoesUserHaveNovel(id);
                    Novel = retrieved;
                }
            );

            AddNovelToUser = new AsyncRelayCommand(
                async () => {
                    await _dataManager.AddNovelToUserList(_novel.Id);
                    IsInUserList = true;
                },
                canExecute: () => _dataManager.IsLoggedIn().Result
            );

            DeleteNovelFromUser = new AsyncRelayCommand(
                async () => {
                    await _dataManager.DeleteNovelFromUser(_novel.Id);
                    IsInUserList = true;
                },
                canExecute: () => _dataManager.IsLoggedIn().Result
            );
        }
    }
}
