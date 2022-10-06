using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using Accord.Video.FFMPEG;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using nilnul.obj.str;

namespace nilnul._avi_._TEST_.anime.extract
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
		{
			var f = @"C:\Users\me\Desktop\tmp\WeChat_20200423235723.mp4";
			var parentDoc = nilnul.fs.address_.spear_.ParentDoc.Parse(f);
			var inputMainExt = nilnul.fs._address.doc_.MainExt.Ov(parentDoc.doc);
			var container = nilnul.fs.address_.spear._ContainerX.TxtUptoLastSep(f);

			//var file2save = nilnul.fs.address_.spear_.ParentDoc(
			//	parentDoc.parent
			//	,
			//	$"{inputMainExt.main}.jpg"

			//);



			var vered = new nilnul.fs.folder.denote_.mainVered_.appendSubIfNeed_.Next(parentDoc.parent);

			var subFolder = nilnul.fs.folder.dir._CreateX.Folder_ofDirName(parentDoc.parent, vered.denote(
$"{inputMainExt.main}-frames"
				)

			);

			Frames(f).Take(10).Each(
				(b, i) =>
				{
					b.Save(


new nilnul.fs.address_.spear_.ParentDoc(
				subFolder.en
				,

					$"frame{i}.jpg"


			).ToString()


					);
				}
			);

			nilnul.fs.folder._ExploreX.Explore(
				subFolder
			);
		}

		static public IEnumerable<Bitmap> Frames(string f)
		{
			//f = @"C:\Users\me\Desktop\tmp\WeChat_20200423235723.mp4";
			using (var vFReader = new VideoFileReader())
			{
				vFReader.Open(f);
				for (int i = 0; i < vFReader.FrameCount; i++)
				{
					yield return vFReader.ReadVideoFrame();
				}

				vFReader.Close();
			}
		}
	}
}
