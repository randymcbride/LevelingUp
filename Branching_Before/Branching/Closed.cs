using Branching;
using System;

namespace OO_Patterns.Branching
{
	public class Closed : IAccountState
	{
		private readonly string accountNumber;

		public IAccountState Close() => throw new AccountClosedException(accountNumber);

		public IAccountState Deposit(Action deposit) => throw new AccountClosedException(accountNumber);

		public IAccountState Freeze() => throw new AccountClosedException(accountNumber);

		public IAccountState Verify() => throw new AccountClosedException(accountNumber);

		public IAccountState Withdraw(Action withdraw) => throw new AccountClosedException(accountNumber);

		public Closed(string accountNumber)
		{
			this.accountNumber = accountNumber;
		}
	}
}
