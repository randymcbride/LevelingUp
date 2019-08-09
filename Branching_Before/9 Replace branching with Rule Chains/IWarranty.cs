using System;

namespace OO_Patterns._9_ChainRules
{
	public interface IWarranty
	{
		void Claim(DateTime date, Action onValidClaim = null);
	}
}
