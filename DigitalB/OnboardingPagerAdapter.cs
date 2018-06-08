using System;
using Android.Support.V4.App;

namespace DigitalB
{
	public class OnboardingPagerAdapter : FragmentPagerAdapter
    {

		public OnboardingPagerAdapter(FragmentManager fm) : base(fm)
		{
		}

		public override int Count {
			get {
				return 3;
			}
		}

		public override Fragment GetItem(int position)
		{
			switch (position)
			{
				case 0: 
					return new OnboardingOneFragment();
					break;
				case 1:
					return new OnboardingTwoFragment();
					break;
				default:
					return new OnboardingOneFragment();
					break;
			}
		}
	}
}
