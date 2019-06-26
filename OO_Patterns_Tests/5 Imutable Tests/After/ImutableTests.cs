using Microsoft.VisualStudio.TestTools.UnitTesting;
using OO_Patterns._5_Imutable_Objects.After;

namespace OO_Patterns_Tests._5_Imutable_Tests.Before
{
	[TestClass]
	public class ImutableTestsAfter
	{
		[TestMethod]
		public void PurchaseApproved_WhenFlashSale()
		{
			var cost = new MoneyAmount(10, "$");
			var accountBalance = new MoneyAmount(6, "$");
			var cart = new ShopppingCart
			{
				IsFlashSale = true
			};
			cart.Buy(cost, accountBalance);
			Assert.AreEqual(1, accountBalance.Amount);
		}
	}
}
