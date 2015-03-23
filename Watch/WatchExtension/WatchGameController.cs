using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;
using System.Timers;
using WatchKit;

namespace WatchExtension
{
	partial class WatchGameController : WatchKit.WKInterfaceController
	{
		int watchTaps = 0;
		int phoneTaps = 0;
		int secondsRemaining = 30;
		Timer timer;

		public WatchGameController (IntPtr handle) : base (handle)
		{
		}

		public override void Awake (NSObject context)
		{
			base.Awake (context);

			// Configure interface objects here.
			timer = new Timer (1000);
			timer.Elapsed += (sender, e) => {
				secondsRemaining--;
				if (secondsRemaining <= 0) {
					timer.Enabled = false;
					InvokeOnMainThread(() =>  PushController("WatchResultsController", NSNumber.FromInt32(watchTaps)) );
					return;
				}
				InvokeOnMainThread(() => {
					if (secondsRemaining == 10) {
						timerLabel.SetTextColor(UIKit.UIColor.Red);
					}
					timerLabel.SetText(String.Format("00:{0:00}", secondsRemaining));
				});
			};
		}

		public override void WillActivate ()
		{
			// This method is called when the watch view controller is about to be visible to the user.
			WatchComm.Wormhole.PassMessage("startGame", true);
			WatchComm.Wormhole.ListenForMessage<int> ("phoneTaps", (count) => {
				if (count > phoneTaps) {
					phoneTaps = count;
					InvokeOnMainThread(() => phoneCountLabel.SetText(String.Format("Phone: {0}", phoneTaps)));
				}
			});
			timer.Enabled = true;
		}

		public override void DidDeactivate ()
		{
			// This method is called when the watch view controller is no longer visible to the user.
			watchTaps = 0;
			phoneTaps = 0;
			secondsRemaining = 30;
		}


		partial void tapButton_Activated (WKInterfaceButton sender)
		{
			watchTaps++;
			watchCountLabel.SetText(String.Format("Watch: {0}", watchTaps));
			WatchComm.Wormhole.PassMessage("watchTaps", watchTaps);
		}
	}
}
