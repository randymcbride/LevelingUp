using Branching;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace OO_Patterns_Tests
{
	[TestClass]
	public class AccountBadTests
	{
		private Action resetFreezeTimer;

		[TestInitialize]
		public void Setup()
		{
			resetFreezeTimer = () =>
			{
				//beep-boop-beep [RESETTING TIMER]
			};
		}

		[TestMethod]
		[ExpectedException(typeof(AccountNotVerifiedException))]
		public void Unverified()
		{
			var account = new AccountBad(resetFreezeTimer, "1");
			account.Deposit(1);
			account.Withdraw(1);
		}

		[TestMethod]
		public void	Verified()
		{
			var account = new AccountBad(resetFreezeTimer, "1")
			{
				IsVerified = true
			};
			account.Deposit(1);
			account.Withdraw(1);
			Assert.AreEqual(account.Balance, 0);
		}

		[TestMethod]
		[ExpectedException(typeof(AccountFrozenException))]
		public void Frozen()
		{
			var account = new AccountBad(resetFreezeTimer, "1")
			{
				IsFrozen = true
			};
			account.Deposit(1);
			account.Withdraw(1);
		}

		[TestMethod]
		[ExpectedException(typeof(AccountClosedException))]
		public void Closed()
		{
			var account = new AccountBad(resetFreezeTimer, "1")
			{
				IsClosed = true
			};
			account.Deposit(1);
			account.Withdraw(1);
		}
	}
}
