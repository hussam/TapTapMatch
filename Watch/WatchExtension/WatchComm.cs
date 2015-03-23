using System;
using WormHoleSharp;

namespace WatchExtension
{
	public static class WatchComm
	{
		public static readonly Wormhole Wormhole = new Wormhole ("group.co.hussam.wristcontrol", "messageDir");
	}
}

