﻿using System.Threading.Tasks;
using MvvmCross.Core.Navigation;
using MvvmCross.Core.ViewModels;

namespace NavigationDrawerTest.Core.ViewModels
{
    public class MainViewModel : MvxViewModel
    {
        private readonly IMvxNavigationService _navigationService;

        public MainViewModel(IMvxNavigationService navigationService)
        {
            _navigationService = navigationService;
            Init();
        }

        public async void Init()
        {
            await _navigationService.Navigate<FirstViewModel>();
        }

        //Task Initialize not called
        //public override async Task Initialize()
        //{
        //    ShowViewModel<FirstViewModel>();
        //}
    }
}
