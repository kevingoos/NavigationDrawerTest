using Android.OS;
using Android.Runtime;
using Android.Views;
using MvvmCross.Binding.Droid.BindingContext;
using MvvmCross.Droid.Support.V4;
using MvvmCross.Droid.Shared.Attributes;
using NavigationDrawerTest.Core.ViewModels;

namespace NavigationDrawerTest.Droid.Activities
{
    [MvxFragment(typeof(MainViewModel), Resource.Id.content_frame, true)]
    [Register(nameof(FirstFragment))]
    public class FirstFragment : MvxFragment<FirstViewModel>
    {
        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            base.OnCreateView(inflater, container, savedInstanceState);
            var view = this.BindingInflate(Resource.Layout.FirstView, container, false);
            return view;
        }
    }
}
