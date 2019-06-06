using Branching;
using System;
using System.Collections.Generic;
using System.Text;

namespace OO_Patterns.Branching
{
	public class Unverified : IAccountState
	{
		private readonly string accountNumber;
		private readonly Action resetFreezeTimer;

		public Unverified(Action resetFreezeTimer, string accountNumber)
		{
			this.accountNumber = accountNumber;
			this.resetFreezeTimer = resetFreezeTimer;
		}
		public IAccountState Close() => new Closed(accountNumber);

		public IAccountState Deposit(Action deposit)
		{
			deposit();
			return this;
		}

		public IAccountState Freeze() => new Frozen(accountNumber);

		public IAccountState Verify() => new Active(resetFreezeTimer, accountNumber);

		public IAccountState Withdraw(Action withdraw) => throw new AccountNotVerifiedException();
	}
}
