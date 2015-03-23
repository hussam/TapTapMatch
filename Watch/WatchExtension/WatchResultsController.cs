using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace WatchExtension
{
	partial class WatchResultsController : WatchKit.WKInterfaceController
	{
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
			}
		}

		partial void dismissButton_Activated (WatchKit.WKInterfaceButton sender)
		{
			PopToRootController();
		}
	}
}
