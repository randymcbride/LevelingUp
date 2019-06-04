using System;

namespace Branching
{

	public class AccountException : Exception
	{
		public string AccountNumer { get; set; }
		public AccountException()
		{

		}

		public AccountException(string message) : base(message)
		{

		}
	}

	public class AccountClosedException : Exception
	{
		public string AccountNumer { get; set; }
		public AccountClosedException()
		{

		}

		public AccountClosedException(string accountNumber)
			: base(accountNumber + " is closed.")
		{

		}
	}

	public class AccountFrozenException : Exception
	{
		public string AccountNumer { get; set; }
		public AccountFrozenException()
		{

		}
		public AccountFrozenException(string accountNumber)
					: base(accountNumber + " is frozen.")
		{

		}
	}

	public class AccountNotVerifiedException : Exception
	{
		public string AccountNumer { get; set; }
		public AccountNotVerifiedException()
		{

		}

		public AccountNotVerifiedException(string accountNumber)
					: base(accountNumber + " is not verified.")
		{

		}
	}
}
