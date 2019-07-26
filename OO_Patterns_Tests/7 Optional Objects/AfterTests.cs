using Microsoft.VisualStudio.TestTools.UnitTesting;
using OO_Patterns._7_Optional_Objects;
using OO_Patterns._7_Optional_Objects.After;
using System;

namespace OO_Patterns_Tests._7_Optional_Objects.After
{
	[TestClass]
	public class AfterTests
	{
		[TestMethod]
		public void DoesNotThrowExceptions_WhenArticleDoesnNotHaveCircuit()
		{
			var article = new SoldArticle();
			article.ClaimCircuitryWarranty(() => { });
		}

		[TestMethod]
		public void ProcessesWarranty_WithCircuit()
		{
			var article = new SoldArticle();
			article.InstallCircuitry
			(
				new Component(DateTime.Now),
				new TimeWarranty(DateTime.Now, TimeSpan.FromDays(365))
			);
			article.InGoodCondition(true);

			bool warrantyProcessed = false;
			article.CircuitryNotOperational(DateTime.Now.AddDays(1));
			article.ClaimCircuitryWarranty(() => { warrantyProcessed = true; });
			Assert.IsTrue(warrantyProcessed);
		}
	}
}
