using System;
using System.Collections.Generic;
using System.Text;

namespace OO_Patterns.Branching
{
	public class Active : IAccountState
	{
		private readonly string accountNumber;
		private readonly Action resetFreezeTimer;

		public Active(Action resetFreezeTimer, string accountNumber)
		{
			this.accountNumber = accountNumber;
			this.resetFreezeTimer = resetFreezeTimer;
		}
		public IAccountState Close() => new Closed(accountNumber);

		public IAccountState Deposit(Action deposit)
		{
			resetFreezeTimer();
			deposit();
			return this;
		}

		public IAccountState Freeze() => new Frozen(accountNumber);

		public IAccountState Verify() => this;

		public IAccountState Withdraw(Action withdraw)
		{
			resetFreezeTimer();
			withdraw();
			return this;
		}
	}
}
