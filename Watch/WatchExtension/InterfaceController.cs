using System;

using WatchKit;
using Foundation;
using System.Timers;

namespace WatchExtension
{
	public partial class InterfaceController : WKInterfaceController
	{
		int tapCount = 0;
		int secondsRemaining = 30;
		Timer timer;

		public InterfaceController (IntPtr handle) : base (handle)
		{
		}

		public override void Awake (NSObject context)
		{
			base.Awake (context);

			// Configure interface objects here.
			timer = new Timer (1000);
			timer.Elapsed += (sender, e) => {
				secondsRemaining--;
				InvokeOnMainThread(() => {
					if (secondsRemaining == 10) {
						timerLabel.SetTextColor(UIKit.UIColor.Red);
					}
					timerLabel.SetText(String.Format("00:{0:00}", secondsRemaining));
				});
				if (secondsRemaining == 0) {
					timer.Enabled = false;
					InvokeOnMainThread(() =>  PushController("results", NSNumber.FromInt32(tapCount)) );
				}
			};
		}

		public override void WillActivate ()
		{
			// This method is called when the watch view controller is about to be visible to the user.
			WatchExt.Wormhole.PassMessage("startGame", true);
			timer.Enabled = true;
		}

		public override void DidDeactivate ()
		{
			// This method is called when the watch view controller is no longer visible to the user.
		}


		partial void tapButton_Activated (WKInterfaceButton sender)
		{
			tapCount++;
			countsLabel.SetText(tapCount.ToString());
			WatchExt.Wormhole.PassMessage("watchTaps", tapCount);
		}
	}
}

