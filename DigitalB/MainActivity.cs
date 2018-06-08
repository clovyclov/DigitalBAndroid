using Android.App;
using Android.Widget;
using Android.OS;
using Android.Support.V4.View;

namespace DigitalB
{
	[Activity(Label = "DigitalB", MainLauncher = true, Icon = "@mipmap/icon", Theme = "@style/Theme.AppCompat.Light.NoActionBar")]
	public class MainActivity : Android.Support.V4.App.FragmentActivity
    {

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);
			ViewPager viewPager = FindViewById<ViewPager>(Resource.Id.viewPager1);

			viewPager.Adapter = new OnboardingPagerAdapter(SupportFragmentManager);

			var transaction = SupportFragmentManager.BeginTransaction();
			transaction.Replace(Resource.Id.viewPager1, new OnboardingOneFragment());
			transaction.Commit();
        }
    }
}

