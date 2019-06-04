using Branching;
using System;

namespace Branching
{
	public class AccountBad
	{
		public string AccountNumber { get; private set; }
		public bool IsFrozen { get; private set; }
		public bool IsClosed { get; private set; }
		public bool IsVerified { get; private set; }
		public decimal Balance { get; private set; }
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
			Balance += amount;
		}
		public void Verify()
		{
			IsVerified = true;
		}

		public AccountBad(string accountNumber)
		{
			AccountNumber = accountNumber;
			Balance = 0;
			IsFrozen = false;
			IsClosed = false;
			IsVerified = false;
		}

	}
}
