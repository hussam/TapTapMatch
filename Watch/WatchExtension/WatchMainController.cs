using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace WatchExtension
{
	partial class WatchMainController : WatchKit.WKInterfaceController
	{
		public WatchMainController (IntPtr handle) : base (handle)
		{
		}

		public override void Awake (NSObject context)
		{
			base.Awake (context);
			startGameButton.SetHidden (true);
			lblLaunchApp.SetHidden (false);
			WatchComm.Wormhole.ListenForMessage<bool> ("isPhoneRunning", (isReady) => {
				lblLaunchApp.SetHidden(isReady);
				startGameButton.SetHidden(!isReady);
			});
		}

		partial void startGameButton_Activated (WatchKit.WKInterfaceButton sender)
		{
			PushController("WatchGameController", null);
		}
	}
}
