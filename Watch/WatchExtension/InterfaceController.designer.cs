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
	[Register ("InterfaceController")]
	partial class InterfaceController
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		WatchKit.WKInterfaceLabel countsLabel { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		WatchKit.WKInterfaceButton tapButton { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		WatchKit.WKInterfaceLabel timerLabel { get; set; }

		[Action ("tapButton_Activated:")]
		[GeneratedCode ("iOS Designer", "1.0")]
		partial void tapButton_Activated (WatchKit.WKInterfaceButton sender);

		void ReleaseDesignerOutlets ()
		{
			if (countsLabel != null) {
				countsLabel.Dispose ();
				countsLabel = null;
			}
			if (tapButton != null) {
				tapButton.Dispose ();
				tapButton = null;
			}
			if (timerLabel != null) {
				timerLabel.Dispose ();
				timerLabel = null;
			}
		}
	}
}
