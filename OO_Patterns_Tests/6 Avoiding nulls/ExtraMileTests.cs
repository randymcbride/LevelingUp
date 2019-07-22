using Microsoft.VisualStudio.TestTools.UnitTesting;
using OO_Patterns._6_Avoiding_Nulls.ExtraMile;
using System;

namespace OO_Patterns_Tests._6_Avoiding_nulls
{
	[TestClass]
	public class ExtraMileTests
	{
		[TestMethod]
		public void UseWarranty_GoodCondition()
		{
			var article = new SoldArticle();
			article.InGoodCondition(true);
			bool wasReturned = false;
			article.Warranty.Claim(DateTime.Now.AddDays(1), () => wasReturned = true);

			Assert.IsTrue(wasReturned);
		}

		[TestMethod]
		public void UseWarranty_BadCondition()
		{
			var article = new SoldArticle();
			article.InGoodCondition(false);
			bool wasReturned = false;
			article.Warranty.Claim(DateTime.Now.AddDays(1), () => wasReturned = true);

			Assert.IsFalse(wasReturned);
		}
	}
}
