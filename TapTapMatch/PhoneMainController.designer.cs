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
	[Register ("PhoneMainController")]
	partial class PhoneMainController
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel lblBestScore { get; set; }

		void ReleaseDesignerOutlets ()
		{
			if (lblBestScore != null) {
				lblBestScore.Dispose ();
				lblBestScore = null;
			}
		}
	}
}
