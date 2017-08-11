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
        }

    }
}
