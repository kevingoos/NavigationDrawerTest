using MvvmCross.Core.ViewModels;

namespace NavigationDrawerTest.Core.ViewModels
{
    public class FirstViewModel
        : MvxViewModel
    {
        string hello = "Hello MvvmCross";
        public string Hello
        {
            get => hello;
            set => SetProperty(ref hello, value);
        }
    }
}
