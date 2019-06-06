using Branching;
using System;
using System.Collections.Generic;
using System.Text;

namespace OO_Patterns.Branching
{
	public class Frozen : IAccountState
	{
		private readonly string accountNumber;

		public Frozen(string accountNumber)
		{
			this.accountNumber = accountNumber;
		}

		public IAccountState Close() => new Closed(accountNumber);

		public IAccountState Deposit(Action deposit) => throw new AccountFrozenException(accountNumber);

		public IAccountState Freeze() => throw new AccountFrozenException(accountNumber);

		public IAccountState Verify() => throw new AccountFrozenException(accountNumber);

		public IAccountState Withdraw(Action withdraw) => throw new AccountFrozenException(accountNumber);
	}
}
