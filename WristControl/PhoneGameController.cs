using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;
using WormHoleSharp;
using System.Timers;

namespace TapTapMatch
{
	partial class PhoneGameController : UIViewController
	{
		Wormhole wormhole;
		int watchTaps = 0;
		int phoneTaps = 0;
		int secondsRemaining = 30;

		public PhoneGameController (IntPtr handle) : base (handle)
		{
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();

			// Perform any additional setup after loading the view, typically from a nib.
			wormhole = new Wormhole ("group.co.hussam.wristcontrol", "messageDir");
			wormhole.PassMessage ("isPhoneRunning", true);
			wormhole.ListenForMessage<int> ("watchTaps", (count) => {
				if (count > watchTaps) {
					watchTaps = count;
					InvokeOnMainThread (() => {
						watchTapsLabel.Text = watchTaps.ToString ();
					});
				}
			});
		}

		public override void ViewDidAppear (bool animated)
		{
			base.ViewDidAppear (animated);
			Timer t = new Timer (1000);
			t.Elapsed += (sender, e) => {
				secondsRemaining--;
				if (secondsRemaining <= 0) {
					t.Enabled = false;
					wormhole.PassMessage ("phoneTapsCount", phoneTaps);
					var resultsController = Storyboard.InstantiateViewController("PhoneResultsController") as PhoneResultsController;
					resultsController.PhoneTaps = phoneTaps;
					resultsController.WatchTaps = watchTaps;
					PresentViewController(resultsController, true, null);
					return;
				}
				InvokeOnMainThread (() => {
					if (secondsRemaining == 10) {
						timerLabel.TextColor = UIColor.Red;
					}
					timerLabel.Text = String.Format ("00:{0:00}", secondsRemaining);

				});
			};
			t.Enabled = true;
		}

		partial void tapButton_TouchUpInside (UIButton sender)
		{
			phoneTaps++;
			tapsCountLabel.Text = phoneTaps.ToString ();
			wormhole.PassMessage ("phoneTaps", phoneTaps);
		}
	}
}
