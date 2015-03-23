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

namespace TapTapMatch
{
	[Register ("PhoneGameController")]
	partial class PhoneGameController
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton tapButton { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel tapsCountLabel { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel timerLabel { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel watchTapsLabel { get; set; }

		[Action ("tapButton_TouchUpInside:")]
		[GeneratedCode ("iOS Designer", "1.0")]
		partial void tapButton_TouchUpInside (UIButton sender);

		void ReleaseDesignerOutlets ()
		{
			if (tapButton != null) {
				tapButton.Dispose ();
				tapButton = null;
			}
			if (tapsCountLabel != null) {
				tapsCountLabel.Dispose ();
				tapsCountLabel = null;
			}
			if (timerLabel != null) {
				timerLabel.Dispose ();
				timerLabel = null;
			}
			if (watchTapsLabel != null) {
				watchTapsLabel.Dispose ();
				watchTapsLabel = null;
			}
		}
	}
}
