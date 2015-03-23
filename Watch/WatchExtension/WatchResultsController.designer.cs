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
	[Register ("WatchResultsController")]
	partial class WatchResultsController
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		WatchKit.WKInterfaceButton dismissButton { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		WatchKit.WKInterfaceLabel resultsLabel { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		WatchKit.WKInterfaceLabel winnerLabel { get; set; }

		[Action ("dismissButton_Activated:")]
		[GeneratedCode ("iOS Designer", "1.0")]
		partial void dismissButton_Activated (WatchKit.WKInterfaceButton sender);

		void ReleaseDesignerOutlets ()
		{
			if (dismissButton != null) {
				dismissButton.Dispose ();
				dismissButton = null;
			}
			if (resultsLabel != null) {
				resultsLabel.Dispose ();
				resultsLabel = null;
			}
			if (winnerLabel != null) {
				winnerLabel.Dispose ();
				winnerLabel = null;
			}
		}
	}
}
