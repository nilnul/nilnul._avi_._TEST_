using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;

namespace nilnul._avi_._TEST_.anime.frame_.first
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
		{
			var avi = @"D:\170203\data(wyt\wyt._inbox_\mobile_.honor(Git\bak_\201108(Git\avi_\misc\Screenshots\SVID_20210601_173412_1.mp4";

			var container = nilnul.fs.address_.spear._ContainerX.Shield(avi);
			var output = nilnul.fs.folder.dnt_.vered_.newest_._folder._EnsureNewestBeFolderX.Folder_ofNom(
				new nilnul.fs.Folder(
					container
				)
				,
				"out(!Git"
				);

			var outputFile = new nilnul.fs.folder.denote_.mainVered_.appendSubIfNeed_.Next(output).address( "frame",".jpg");

			var frame = nilnul.avi.anime._ExtractFroFile.Frames(avi).First();

			frame.Save(outputFile);

			nilnul.fs.file._ExeX.Exe(outputFile);



		}
	}
}
