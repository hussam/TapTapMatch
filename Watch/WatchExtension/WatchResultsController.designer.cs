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
		WatchKit.WKInterfaceGroup innerGroup { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		WatchKit.WKInterfaceGroup outerGroup { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		WatchKit.WKInterfaceLabel resultsLabel { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		WatchKit.WKInterfaceLabel winnerLabel { get; set; }

		void ReleaseDesignerOutlets ()
		{
			if (innerGroup != null) {
				innerGroup.Dispose ();
				innerGroup = null;
			}
			if (outerGroup != null) {
				outerGroup.Dispose ();
				outerGroup = null;
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
