using System;

namespace OO_Patterns._7_Optional_Objects
{
	public class VoidWarranty : IWarranty
	{
		public void Claim(DateTime date, Action onValidClaim = null)
		{
		}
	}
}
