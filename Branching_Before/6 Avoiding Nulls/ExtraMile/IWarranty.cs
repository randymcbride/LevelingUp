using System;

namespace OO_Patterns._6_Avoiding_Nulls.ExtraMile
{
	public interface IWarranty
	{
		void Claim(DateTime date, Action onValidClaim = null);
	}
}
