using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace WatchExtension
{
	partial class GameResultsInterfaceController : WatchKit.WKInterfaceController
	{
		int watchTapCount = 0;

		public GameResultsInterfaceController (IntPtr handle) : base (handle)
		{
		}

		public override void Awake (NSObject context)
		{
			base.Awake (context);
			if (context != null) {
				watchTapCount = ((NSNumber)context).Int32Value;
				watchTapsLabel.SetText (watchTapCount.ToString ());

				var phoneTapsCount = WatchExt.Wormhole.MessageWithIdentifier<int> ("phoneTapsCount");
				phoneTapsLabel.SetText (phoneTapsCount.ToString());
			}
		}
	}
}
