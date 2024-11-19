using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace VN_master_detail.ViewModel
{
    public class NavigationVM
    {

        public ICommand GoToHome { get; private set; }

        public ICommand GoToSearch { get; private set; }

        public NavigationVM()
        {
            InitCommand();
        }

        private void InitCommand()
        {
            GoToHome = new AsyncRelayCommand(
                async () => await Shell.Current.GoToAsync("//Home")
            );
            GoToSearch = new AsyncRelayCommand(
                async () => await Shell.Current.GoToAsync("//Search")
            );
        }
    }
}
