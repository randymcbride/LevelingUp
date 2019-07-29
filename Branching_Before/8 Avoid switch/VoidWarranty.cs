using System;

namespace OO_Patterns._8_Avoid_switch
{
	public class VoidWarranty : IWarranty
	{
		public void Claim(DateTime date, Action onValidClaim = null)
		{
		}
	}
}
