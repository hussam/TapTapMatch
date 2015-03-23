using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace WatchExtension
{
	partial class MainController : WatchKit.WKInterfaceController
	{
		public MainController (IntPtr handle) : base (handle)
		{
		}

		public override void Awake (NSObject context)
		{
			base.Awake (context);
			startGameButton.SetHidden (true);
			lblLaunchApp.SetHidden (false);
			WatchExt.Wormhole.ListenForMessage<bool> ("isPhoneRunning", (isReady) => {
				lblLaunchApp.SetHidden(isReady);
				startGameButton.SetHidden(!isReady);
			});
		}

		partial void startGameButton_Activated (WatchKit.WKInterfaceButton sender)
		{
			PushController("game", null);
		}
	}
}
