﻿using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using ViewModel;

namespace VN_master_detail.ViewModel
{
    public class NavigationVM
    {
        private static UserVM _user;

        private INavigation _navigation;

        public ICommand GoToDetail { get; private set; }

        public ICommand GoToHome { get; private set; }

        public ICommand GoToSearch { get; private set; }

        public ICommand GoToLogin { get; private set; }

        public NavigationVM(UserVM? user, INavigation navigation)
        {
            if (user != null) _user = user;
            _navigation = navigation;
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

            GoToLogin = new AsyncRelayCommand(
                async () =>
                {
                    if (!await _user.IsLoggedIn()) await Shell.Current.GoToAsync("//Login");
                    else await Shell.Current.GoToAsync("//Profile");
                }
            );

            GoToDetail = new AsyncRelayCommand<string>(
                async (id) => await _navigation.PushAsync(new NovelDetail(id))
            );
        }
    }
}
