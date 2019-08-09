using Microsoft.VisualStudio.TestTools.UnitTesting;
using OO_Patterns._9_ChainRules;

namespace OO_Patterns_Tests._9_Chained_Rules_Tests
{
	[TestClass]
	public class ChainedRuleTests
	{
		[TestMethod]
		public void Processes_NotOperational()
		{
			var soldArticle = new SoldArticle();

			soldArticle.NotOperational();

			bool processed = false;
			soldArticle.ClaimWarranty(() => processed = true);
			Assert.IsTrue(processed);
		}

		[TestMethod]
		public void Processes_MoneyBack()
		{
			var soldArticle = new SoldArticle();

			soldArticle.Operational();

			bool processed = false;
			soldArticle.ClaimWarranty(() => processed = true);
			Assert.IsTrue(processed);
		}
	}
}
