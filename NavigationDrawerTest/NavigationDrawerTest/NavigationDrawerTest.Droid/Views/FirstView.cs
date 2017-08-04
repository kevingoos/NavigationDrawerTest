using Android.App;
using Android.OS;
using Android.Views;
using Android.Widget;
using MvvmCross.Binding.Droid.BindingContext;
using MvvmCross.Droid.Support.V4;
using NavigationDrawerTest.Core.ViewModels;

namespace NavigationDrawerTest.Droid.Views
{
    public class FirstView : MvxFragment<FirstViewModel>
    {
        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            base.OnCreateView(inflater, container, savedInstanceState);
            var view = this.BindingInflate(Resource.Layout.FirstView, container, false);
            return view;
        }
    }
}
