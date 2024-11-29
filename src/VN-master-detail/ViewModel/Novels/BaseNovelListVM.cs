using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Interfaces;
using Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ViewModel.Novels
{
    public class BaseNovelListVM : ObservableObject
    {
        private readonly ObservableCollection<BaseNovelVM> _list = [];

        public ReadOnlyObservableCollection<BaseNovelVM> List { get; private init; }

        private readonly IDataManager<User> _manager;

        private string _searchedName = string.Empty;

        public string SearchedName 
        {
            get => _searchedName;
            set => SetProperty(ref _searchedName, value);

        }

        private int _page = 0;

        public int Page
        {
            get => _page;
            set => SetProperty(ref _page, value);
        }

        private int _count = 6;

        public int Count
        {
            get => _count;
            set => SetProperty(ref _count, value);
        }

        private bool _isMaxPage;

        public ICommand GetNovels { get; private set; }

        public ICommand GetUserNovels { get; private set; }

        public ICommand SearchNovels { get; private set; }

        public ICommand NextPage { get; private set; }

        public ICommand PreviousPage { get; private set; }

        public BaseNovelListVM(IDataManager<User> manager)
        {
            List = new(_list);
            _manager = manager;
            InitCommand();
        }

        private void InitCommand()
        {
            GetNovels = new AsyncRelayCommand(
                async () =>
                {
                    _list.Clear();
                    var retrieved = await _manager.GetNovels(_page, _count, DTO.Criteria.Name);
                    foreach (var novel in retrieved.Item1)
                    {
                        _list.Add(new BaseNovelVM() { _novel = novel });
                    }
                    _isMaxPage = retrieved.Item2;
                    ((RelayCommand<ICommand>)NextPage).NotifyCanExecuteChanged();
                }
            );

            GetUserNovels = new AsyncRelayCommand(
                async () =>
                {
                    _list.Clear();
                    var retrieved = await _manager.GetNovelsForUser(_page, _count);
                    foreach(var novel in retrieved.Item1)
                    {
                        _list.Add(new BaseNovelVM() { _novel = novel });
                    }
                    _isMaxPage = retrieved.Item2;
                    ((RelayCommand<ICommand>)NextPage).NotifyCanExecuteChanged();
                }
            );

            SearchNovels = new AsyncRelayCommand(
                async () =>
                {
                    _list.Clear();
                    var retrieved = await _manager.GetNovels(_page, _count, DTO.Criteria.Name, SearchedName);
                    foreach(var novel in retrieved.Item1)
                    {
                        _list.Add(new BaseNovelVM() { _novel = novel });
                    }
                    _isMaxPage = retrieved.Item2;
                    ((RelayCommand<ICommand>)NextPage).NotifyCanExecuteChanged();
                }
            );

            // Command passed should be either GetUserNovels OR
            // SearchNovels. Since this is used in both the search
            // and the home pages, we cant just call one or another directly
            // without making another command, or passing it as a parameter.
            NextPage = new RelayCommand<ICommand>(
                (command) =>
                {
                    if (command == null) return;
                    Page += 1;
                    command.Execute(null);
                    ((RelayCommand<ICommand>)PreviousPage).NotifyCanExecuteChanged();
                },
                (ingored) => !_isMaxPage
            );

            // Same thing
            PreviousPage = new RelayCommand<ICommand>(
                (command) =>
                {
                    if (command == null) return;
                    Page -= 1;
                    command.Execute(null);
                    ((RelayCommand<ICommand>)PreviousPage).NotifyCanExecuteChanged();
                },
                (ignored) => _page > 0
            );
        }
    }
}
