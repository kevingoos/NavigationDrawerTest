using System.Threading.Tasks;
using System.Windows.Input;
using MvvmCross.Core.Navigation;
using MvvmCross.Core.ViewModels;

namespace NavigationDrawerTest.Core.ViewModels
{
    public class StartViewModel : MvxViewModel
    {
        private readonly IMvxNavigationService _navigationService;

        public ICommand StartCommand => new MvxAsyncCommand(ExecuteStart);

        public StartViewModel(IMvxNavigationService navigationService)
        {
            _navigationService = navigationService;
        }

        private async Task ExecuteStart()
        {
            await _navigationService.Navigate<FirstViewModel>();
        }
    }
}
