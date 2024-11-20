﻿using ViewModel;
using ViewModel.Novels;
using VN_master_detail.ViewModel;

namespace VN_master_detail
{
    public partial class AcceuilPage : ContentPage
    {
        public BaseNovelListVM Novels { get; private set; }

        public NavigationVM NavigationVM;

        public AcceuilPage(BaseNovelListVM novels,
                           UserVM user)
        {
            Novels = novels;
            NavigationVM = new NavigationVM(user, Navigation);
            BindingContext = this;
            InitializeComponent();
        }
    }

}
