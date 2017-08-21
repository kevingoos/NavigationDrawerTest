using Android.App;
using Android.OS;
using MvvmCross.Droid.Support.V7.AppCompat;
using NavigationDrawerTest.Core.ViewModels;

namespace NavigationDrawerTest.Droid.Activities
{
    [Activity(Label = "Start")]
    public class StartActivity : MvxAppCompatActivity<StartViewModel>
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.StartLayout);
        }
    }
}