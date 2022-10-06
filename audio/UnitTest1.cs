using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace nilnul._avi_._TEST_.audio
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
		{
			///extract audio
			///
			var run = nilnul.win.prog_.ffmpeg.Run.Singleton;

			var avi = @"C:\Users\me\Desktop\tmp\WeChat_20200424133834.mp4";

			var aviParsed = nilnul.fs.address_.spear_.ParentDoc.Parse(avi);

			var mainExt = nilnul.fs._address.doc_.MainExt.Ov(aviParsed.doc);

			var outputFile = new nilnul.fs.folder.denote_.mainVered_.appendSubIfNeed_.Next(aviParsed.parent).denote(
				mainExt+"-sound"
				,".mp3"
			);

			var arg = 
				$"-i {new nilnul.win.prog._run.Arg(mainExt.ToString())} -vn -f mp3 -ab 320k output {new nilnul.win.prog._run.Arg(outputFile)}";

			//Environment.CurrentDirectory = aviParsed.parent.ToString();
			run.runWaitedDispose(
				$"-i {new nilnul.win.prog._run.Arg(mainExt.ToString())} -vn -f mp3 -ab 320k output {new nilnul.win.prog._run.Arg(outputFile)}"
				
				,
				aviParsed.parent.ToString()

			);

			nilnul.fs.file.explore_._SelX.Vod(
				new nilnul.fs.address_.spear_.ParentDoc(aviParsed.parent, outputFile)
			);
		}
	}
}
