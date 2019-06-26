using Microsoft.VisualStudio.TestTools.UnitTesting;
using OO_Patterns._5_Imutable_Objects.Before;

namespace OO_Patterns_Tests._5_Imutable_Tests.Before
{
	[TestClass]
	public class ImutableTests
	{
		[TestMethod]
		public void PurchaseApproved_WhenFlashSale()
		{
			var cost = new MoneyAmount
			{
				Amount = 10,
				CurrencySymbol = "$"
			};
			var accountBalance = new MoneyAmount
			{
				Amount = 6,
				CurrencySymbol = "$"
			};
			var cart = new ShopppingCart
			{
				IsFlashSale = true
			};
			cart.Buy(cost, accountBalance);
			Assert.AreEqual(1, accountBalance.Amount);
		}

		[TestMethod]
		public void PurchaseApproved_WhenEnoughMoney()
		{
			var cost = new MoneyAmount
			{
				Amount = 10,
				CurrencySymbol = "$"
			};
			var accountBalance = new MoneyAmount
			{
				Amount = 20,
				CurrencySymbol = "$"
			};
			var cart = new ShopppingCart();
			cart.Buy(cost, accountBalance);
			Assert.AreEqual(10, accountBalance.Amount);
		}

		[TestMethod]
		public void PurchaseRejected_WhenNotEnoughMoney()
		{
			var cost = new MoneyAmount
			{
				Amount = 10,
				CurrencySymbol = "$"
			};
			var accountBalance = new MoneyAmount
			{
				Amount = 9.99M,
				CurrencySymbol = "$"
			};
			var cart = new ShopppingCart();
			cart.Buy(cost, accountBalance);
			Assert.AreEqual(9.99M, accountBalance.Amount);
		}
	}
}
