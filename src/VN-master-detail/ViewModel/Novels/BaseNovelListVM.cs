using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Interfaces;
using Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

        public ICommand GetNovels { get; private set; }

        public ICommand GetUserNovels { get; private set; }

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
                    var retrieved = await _manager.GetNovels(0, 10, DTO.Criteria.Name);
                    foreach (var novel in retrieved)
                    {
                        _list.Add(new BaseNovelVM() { _novel = novel });
                    }
                }
            );

            GetUserNovels = new AsyncRelayCommand(
                async () =>
                {
                    _list.Clear();
                    var retrived = await _manager.GetNovelsForUser(0, 10);
                    foreach(var novel in retrived)
                    {
                        _list.Add(new BaseNovelVM() { _novel = novel });
                    }
                }
            );
        }
    }
}
