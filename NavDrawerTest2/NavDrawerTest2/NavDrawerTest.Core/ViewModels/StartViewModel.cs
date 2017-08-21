using System.Windows.Input;
using MvvmCross.Core.Navigation;
using MvvmCross.Core.ViewModels;
using MvvmCross.Platform;

namespace NavigationDrawerTest.Core.ViewModels
{
    public class StartViewModel : MvxViewModel
    {
        private readonly IMvxNavigationService _navigationService;

        public ICommand StartCommand => new MvxCommand(ExecuteStart);

        public StartViewModel()
        {
            _navigationService = Mvx.Resolve<IMvxNavigationService>();
        }

        private async void ExecuteStart()
        {
            await _navigationService.Navigate<MainViewModel>();
        }
    }
}
