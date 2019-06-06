using OO_Patterns.Branching;
using System;

namespace Branching
{
	public class AccountGood
	{
		private readonly Action resetFreezeTimer;
		private readonly string accountNumber;
		private IAccountState accountState;

		public decimal Balance { get; private set; }

		public void Withdraw(decimal amount) => 
			accountState = accountState.Withdraw(() => Balance -= amount);

		public void Deposit(decimal amount) => 
			accountState = accountState.Deposit(() => Balance += amount);

		public void Verify() => accountState = accountState.Verify();

		public void Freeze() => accountState = accountState.Freeze();

		public void Close() => accountState = accountState.Close();


		public AccountGood(Action resetFreezeTimer, string accountNumber)
		{
			this.resetFreezeTimer = resetFreezeTimer;
			this.accountNumber = accountNumber;
			this.accountState = new Unverified(resetFreezeTimer, accountNumber);
		}

	}
}
