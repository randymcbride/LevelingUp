using System;

namespace OO_Patterns._9_ChainRules
{
	public class VoidWarranty : IWarranty
	{
		public void Claim(DateTime date, Action onValidClaim = null)
		{
		}
	}
}
