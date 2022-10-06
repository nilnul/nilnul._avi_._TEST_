using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace nilnul._avi_._TEST_.co.concat
{
	[TestClass]
	public class UnitTest11
	{
		[TestMethod]
		public void TestMethod1()
		{


			var input = nilnul.fs.address_.spear_.ParentDoc.Parse(@"C:\Users\me\AppData\Local\Temp\AviOfMic\combined.mp4");
			var docExted = nilnul.fs._address.doc_.MainExt.Ov(input.doc);
			var output = new nilnul.fs.folder.denote_.mainVered_.appendSubIfNeed_.Next(input.parent).denote(docExted.main + "-trunced" + docExted.ext);

			/*
Please read the FFMPEG FAQ for information about joining files.

			Unfortunately, since you're using MP4 files, simple concatenation won't work for you because the MP4 format contains a "header" (although it doesn't necessarily have to be at the beginning of the file) section that describes and contains offsets into the media data. You will need to transcode both files to a format that can be concatenated and then generate an MP4 file from that format (which will generate an appropriate header section).


As previous answers show, you need to convert first to an intermediate format. If the mp4 contains h264 bitstream, you can use:

ffmpeg -i input1.mp4 -c copy -bsf:v h264_mp4toannexb -f mpegts input1.ts
ffmpeg -i input2.mp4 -c copy -bsf:v h264_mp4toannexb -f mpegts input2.ts
ffmpeg -i "concat:input1.ts|input2.ts" -c copy output.mp4


A more detailed answer you can find here.

						 */

			nilnul.win.prog_.ffmpeg.Run.Singleton.runWaitedDispose(
				$"-f concat -i {new nilnul.win.prog._run.Arg(input.doc.ToString())} {new nilnul.win.prog._run.Arg(output)}"
		
				,
				input.parent.ToString()
			);
		}
	}
}
