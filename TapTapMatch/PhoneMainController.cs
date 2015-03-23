using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;
using WormHoleSharp;

namespace TapTapMatch
{
	partial class PhoneMainController : UIViewController
	{
		Wormhole wormhole;

		public PhoneMainController (IntPtr handle) : base (handle)
		{
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			wormhole = new Wormhole("group.co.hussam.wristcontrol", "messageDir");
		}

		public override void ViewDidAppear (bool animated)
		{
			base.ViewDidAppear (animated);
			wormhole.PassMessage ("isPhoneRunning", true);
			wormhole.ListenForMessage<bool> ("startGame", (x) => {
				var gameController = Storyboard.InstantiateViewController("GameController");
				PresentViewController(gameController, true, null);
			});
		}
	}
}
