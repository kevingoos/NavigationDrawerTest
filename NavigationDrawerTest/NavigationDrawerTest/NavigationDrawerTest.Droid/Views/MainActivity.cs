using Android.App;
using Android.OS;
using Android.Support.V4.Widget;
using Android.Support.V7.App;
using Android.Support.V7.Widget;

namespace NavigationDrawerTest.Droid.Views
{
    [Activity(Label = "Navigation Drawer")]
    public class MainActivity : BaseView
    {
        private DrawerLayout _drawerLayout;
        private ActionBarDrawerToggle _drawerToggle;

        protected override int LayoutResource => Resource.Layout.MainView;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            var toolbar = FindViewById<Toolbar>(Resource.Id.toolbar);
            SetSupportActionBar(toolbar);

            _drawerLayout = FindViewById<DrawerLayout>(Resource.Id.drawer_layout);
            _drawerToggle = new ActionBarDrawerToggle(this, _drawerLayout, toolbar, Resource.String.drawer_open, Resource.String.drawer_close);
            

            SupportFragmentManager.BeginTransaction().Replace(Resource.Id.content_frame, new FirstView()).Commit();
            SupportActionBar.SetDisplayHomeAsUpEnabled(false);
            SupportActionBar.SetDisplayHomeAsUpEnabled(true);

            _drawerLayout.AddDrawerListener(_drawerToggle);
            _drawerToggle.SyncState();
        }
    }
}