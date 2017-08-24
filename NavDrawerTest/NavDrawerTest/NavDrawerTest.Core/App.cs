using MvvmCross.Core.ViewModels;
using MvvmCross.Platform.IoC;
using NavigationDrawerTest.Core.ViewModels;

namespace NavigationDrawerTest.Core
{
    public class App : MvxApplication
    {
        public override void Initialize()
        {
            CreatableTypes()
                .EndingWith("Service")
                .AsInterfaces()
                .RegisterAsLazySingleton();

            RegisterNavigationServiceAppStart<FirstViewModel>();
        }
    }
}
