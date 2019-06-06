using System;
using System.Collections.Generic;
using System.Text;

namespace OO_Patterns.Branching
{
	public interface IAccountState
	{
		IAccountState Deposit(Action deposit);
		IAccountState Withdraw(Action withdraw);
		IAccountState Freeze();
		IAccountState Close();
		IAccountState Verify();
	}
}
