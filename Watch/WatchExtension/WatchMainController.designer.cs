// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace WatchExtension
{
	[Register ("WatchMainController")]
	partial class WatchMainController
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		WatchKit.WKInterfaceLabel lblLaunchApp { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		WatchKit.WKInterfaceButton startGameButton { get; set; }

		[Action ("startGameButton_Activated:")]
		[GeneratedCode ("iOS Designer", "1.0")]
		partial void startGameButton_Activated (WatchKit.WKInterfaceButton sender);

		void ReleaseDesignerOutlets ()
		{
			if (lblLaunchApp != null) {
				lblLaunchApp.Dispose ();
				lblLaunchApp = null;
			}
			if (startGameButton != null) {
				startGameButton.Dispose ();
				startGameButton = null;
			}
		}
	}
}
