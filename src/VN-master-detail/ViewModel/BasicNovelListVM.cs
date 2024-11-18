using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Interfaces;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ViewModel
{
    public class BasicNovelListVM : ObservableObject
    {
        private readonly ObservableCollection<BasicNovelVM> _list = new();

        public ReadOnlyObservableCollection<BasicNovelVM> List { get; }

        private readonly IDataManager _manager;

        public ICommand GetNovels { get; set; }

        public BasicNovelListVM(IDataManager manager)
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
                    foreach(var novel in retrieved)
                    {
                        _list.Add(new BasicNovelVM() { _novel = novel });
                    }
                }
            );
        }
    }
}
