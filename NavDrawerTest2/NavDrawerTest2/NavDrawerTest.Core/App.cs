using MvvmCross.Platform.IoC;
using NavigationDrawerTest.Core.ViewModels;

namespace NavigationDrawerTest.Core
{
    public class App : MvvmCross.Core.ViewModels.MvxApplication
    {
        public override void Initialize()
        {
            CreatableTypes()
                .EndingWith("Service")
                .AsInterfaces()
                .RegisterAsLazySingleton();

            RegisterNavigationServiceAppStart<StartViewModel>();
        }
    }
}
