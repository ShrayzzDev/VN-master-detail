using CommunityToolkit.Mvvm.ComponentModel;
using Interfaces;
using Model;
using NullInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModel
{
    public class UserVM : ObservableObject
    {
        private readonly IDataManager<User> _dataManager;

        public string Username
        {
            get => _dataManager.ConnectedUser == null ? string.Empty : _dataManager.ConnectedUser.Username;
        }

        public string[] Permissions
        {
            get => _dataManager.ConnectedUser == null ? [] : _dataManager.ConnectedUser.Permissions;
        }

        public UserVM(IDataManager<User> dataManager)
        {
            _dataManager = dataManager;
        }

        public Task<bool> Login(string apiKey)
            => _dataManager.Login(apiKey);

        public Task<bool> IsLoggedIn()
            => _dataManager.IsLoggedIn();
    }
}
