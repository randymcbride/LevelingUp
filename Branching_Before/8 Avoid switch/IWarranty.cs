using System;

namespace OO_Patterns._8_Avoid_switch
{
	public interface IWarranty
	{
		void Claim(DateTime date, Action onValidClaim = null);
	}
}
