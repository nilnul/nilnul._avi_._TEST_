using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace nilnul.win.prog_.ffplay.run
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
		 {
			nilnul.win.prog_.ffplay.Run.Singleton.runWaitedDispose(
				@"D:\170203\data\nilnul._avi_\eg_(Git\WeChat_20180612135727.mp4"
			//@"C:\Users\me\Desktop\tmp\FinalVideo.mp4"
			//@"C:\Users\me\Desktop\tmp\zfcg_live_2.m3u8"
			);
		}
	}
}
