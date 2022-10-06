using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace nilnul._avi_._TEST_.op_.unary_.trunc_.accord
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
		{
			var input =nilnul.fs.address_.spear_.ParentDoc.Parse(@"C:\Users\me\AppData\Local\Temp\AviOfMic\combined.mp4");
			var docExted = nilnul.fs._address.doc_.MainExt.Ov(input.doc);
			var output = new nilnul.fs.folder.denote_.mainVered_.appendSubIfNeed_.Next(input.parent).denote(docExted.main + "-trunced" + docExted.ext);

			

			nilnul.win.prog_.ffmpeg.Run.Singleton.runWaitedDispose(
				$"-t {new TimeSpan(0,9,3).TotalSeconds} -i {new nilnul.win.prog._run.Arg(input.doc.ToString())} {new nilnul.win.prog._run.Arg(output)}"
				/*Option 'sameq' was removed. If you are looking for an option to preserve the quality (which is not what -sameq was for), use -qscale 0 or an equivalent quality factor option.
Failed to set value '1' for option 'sameq': Invalid argument
Error parsing global options: Invalid argument
*/
				,
				input.parent.ToString()
			);
		}
	}
}
