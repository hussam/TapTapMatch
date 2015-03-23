using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace WatchExtension
{
	partial class WatchResultsController : WatchKit.WKInterfaceController
	{
		const double duration = 1;

		public WatchResultsController (IntPtr handle) : base (handle)
		{
		}

		public override void Awake (NSObject context)
		{
			base.Awake (context);
			if (context != null) {
				var watchTapCount = ((NSNumber)context).Int32Value;
				var phoneTapsCount = WatchComm.Wormhole.MessageWithIdentifier<int> ("phoneTapsCount");

				string winner;
				if (watchTapCount > phoneTapsCount) {
					winner = "Watch WINS!!!";
				} else {
					winner = "Phone WINS!!!";
				}
				winnerLabel.SetText (winner);
				resultsLabel.SetText (String.Format ("{0} - {1}", watchTapCount, phoneTapsCount));

				outerGroup.SetBackgroundImage ("outerArc/outer");
				innerGroup.SetBackgroundImage ("innerArc/inner");
				outerGroup.StartAnimating (new NSRange (0, phoneTapsCount), duration, 1);
				innerGroup.StartAnimating (new NSRange (0, watchTapCount), duration, 1);
			}
		}

		/*
		partial void dismissButton_Activated (WatchKit.WKInterfaceButton sender)
		{
			PopToRootController();
		}
		*/
	}
}
