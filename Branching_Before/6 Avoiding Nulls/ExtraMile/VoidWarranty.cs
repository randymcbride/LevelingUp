using System;

namespace OO_Patterns._6_Avoiding_Nulls.ExtraMile
{
	public class VoidWarranty : IWarranty
	{
		public void Claim(DateTime date, Action onValidClaim = null)
		{
		}
	}
}
