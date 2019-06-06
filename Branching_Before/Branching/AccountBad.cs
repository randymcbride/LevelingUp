using Branching;
using System;

namespace Branching
{
	public class AccountBad
	{
		public string AccountNumber { get; private set; }
		public bool IsFrozen { get; set; }
		public bool IsClosed { get; set; }
		public bool IsVerified { get; set; }
		private readonly Action resetFreezeTimer;

		public decimal Balance { get; set; }
		public void Withdraw(decimal amount)
		{
			if (IsFrozen)
			{
				throw new AccountFrozenException(AccountNumber);
			}
			if (IsClosed)
			{
				throw new AccountClosedException(AccountNumber);
			}
			if (!IsVerified)
			{
				throw new AccountNotVerifiedException(AccountNumber);
			}
			resetFreezeTimer();
			Balance -= amount;
		}
		public void Deposit(decimal amount)
		{
			if (IsFrozen)
			{
				throw new AccountFrozenException(AccountNumber);
			}
			if (IsClosed)
			{
				throw new AccountClosedException(AccountNumber);
			}
			resetFreezeTimer();
			Balance += amount;
		}
		public void Verify()
		{
			IsVerified = true;
		}

		public AccountBad(Action resetFreezeTimer, string accountNumber)
		{
			AccountNumber = accountNumber;
			Balance = 0;
			IsFrozen = false;
			IsClosed = false;
			IsVerified = false;
			this.resetFreezeTimer = resetFreezeTimer;
		}

	}
}
