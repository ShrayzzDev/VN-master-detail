﻿using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Interfaces;
using Model;
using Model.Novel;
using Model.Producer;
using Model.Title;
using System.Windows.Input;

namespace ViewModel
{
    public class DetailedNovelVM : ObservableObject
    {
        private readonly IDataManager<User> _dataManager;

        private DetailedNovel _novel = new();

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
            }
        }

        public string Title
        {
            get => _novel.Title;
            set => SetProperty(_novel.Title, value, callback: (value) => { Novel.Title = value; });
        }
        
        // TODO : Needs a VM !!!!!
        public List<SimpleTitle> Titles
        {
            get => _novel.Titles;
        }

        // TODO : Needs a VM too !!!!!
        public SimpleProducer[] Developpers
        {
            get => _novel.Developpers;
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

        public ICommand RetrieveNovel { get; set; }

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
                    Novel = retrieved;
                }
            );
        }
    }
}
