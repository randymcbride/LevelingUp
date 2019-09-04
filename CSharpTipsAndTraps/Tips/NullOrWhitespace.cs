using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CSharpTipsAndTraps.Tips
{
	[TestClass]
	public class NullOrWhitespace
	{
		[TestMethod]
		public void DetectsEmptyStrings()
		{
			Assert.IsTrue(string.IsNullOrWhiteSpace(string.Empty));
		}
	}
}
