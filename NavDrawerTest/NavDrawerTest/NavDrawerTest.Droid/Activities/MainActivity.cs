using Android.App;
using Android.Content.Res;
using Android.OS;
using Android.Support.V4.Widget;
using Android.Support.V7.App;
using Android.Support.V7.Widget;
using MvvmCross.Droid.Support.V7.AppCompat;
using NavigationDrawerTest.Core.ViewModels;

namespace NavigationDrawerTest.Droid.Activities
{
    [Activity(Label = "Navigation Drawer")]
    public class MainActivity : MvxCachingFragmentCompatActivity<MainViewModel>
    {
        private DrawerLayout _drawerLayout;
        private ActionBarDrawerToggle _drawerToggle;
        
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.MainView);

            var toolbar = FindViewById<Toolbar>(Resource.Id.toolbar);
            SetSupportActionBar(toolbar);

            _drawerLayout = FindViewById<DrawerLayout>(Resource.Id.drawer_layout);
            _drawerToggle = new ActionBarDrawerToggle(this, _drawerLayout, toolbar, Resource.String.drawer_open, Resource.String.drawer_close);
            
            SupportActionBar.SetDisplayHomeAsUpEnabled(false);
            SupportActionBar.SetDisplayHomeAsUpEnabled(true);

            _drawerLayout.AddDrawerListener(_drawerToggle);
            _drawerToggle.SyncState();
        }

        protected override void OnPostCreate(Bundle savedInstanceState)
        {
            base.OnPostCreate(savedInstanceState);
            // Sync the toggle state after onRestoreInstanceState has occurred.
            _drawerToggle.SyncState();
        }

        public override void OnConfigurationChanged(Configuration newConfig)
        {
            base.OnConfigurationChanged(newConfig);
            // Pass any configuration change to the drawer toggls
            _drawerToggle.OnConfigurationChanged(newConfig);
        }
    }
}