using Branching;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace OO_Patterns_Tests
{
	[TestClass]
	public class Branching
	{
		[TestMethod]
		[ExpectedException(typeof(AccountNotVerifiedException))]
		public void Withdraw_Unverified()
		{
			var account = new AccountBad("1");
			account.Deposit(1);
			account.Withdraw(1);
		}

		[TestMethod]
		public void	WithdrawVerified()
		{
			var account = new AccountBad("1");
			account.Deposit(1);
			account.Withdraw(1);
			Assert.AreEqual(account.Balance, 0);
		}
	}
}
