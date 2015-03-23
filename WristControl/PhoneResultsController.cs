using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace TapTapMatch
{
	partial class PhoneResultsController : UIViewController
	{
		public int PhoneTaps = 0;
		public int WatchTaps = 0;

		public PhoneResultsController (IntPtr handle) : base (handle)
		{
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			string winner;
			if (PhoneTaps > WatchTaps) {
				winner = "Phone WINS!!!";
			} else {
				winner = "Watch WINS!!!";
			}
			winnerLabel.Text = winner;

			resultsLabel.Text = String.Format ("{0} - {1}", PhoneTaps, WatchTaps);
		}

		partial void dissmissButton_TouchUpInside (UIButton sender)
		{
			DismissViewController(true, null);
		}
	}
}
