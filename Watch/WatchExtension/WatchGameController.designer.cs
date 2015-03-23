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
	[Register ("WatchGameController")]
	partial class WatchGameController
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		WatchKit.WKInterfaceLabel phoneCountLabel { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		WatchKit.WKInterfaceButton tapButton { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		WatchKit.WKInterfaceLabel timerLabel { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		WatchKit.WKInterfaceLabel watchCountLabel { get; set; }

		[Action ("tapButton_Activated:")]
		[GeneratedCode ("iOS Designer", "1.0")]
		partial void tapButton_Activated (WatchKit.WKInterfaceButton sender);

		void ReleaseDesignerOutlets ()
		{
			if (phoneCountLabel != null) {
				phoneCountLabel.Dispose ();
				phoneCountLabel = null;
			}
			if (tapButton != null) {
				tapButton.Dispose ();
				tapButton = null;
			}
			if (timerLabel != null) {
				timerLabel.Dispose ();
				timerLabel = null;
			}
			if (watchCountLabel != null) {
				watchCountLabel.Dispose ();
				watchCountLabel = null;
			}
		}
	}
}
