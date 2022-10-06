using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace nilnul._avi_._TEST_.audio.extract
{
	[TestClass]
	public class UnitTest1
	{

		[TestMethod]
		public void TestMethod1()
		{
			var f=nilnul.avi.sound._ExtractX.ParentDoc(@"C:\Users\me\Desktop\tmp\WeChat_20200510235218.mp4");
			nilnul.fs.file.explore_._SelX.Vod(f);
		}
	}
}
