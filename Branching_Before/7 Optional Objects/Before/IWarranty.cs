using System;

namespace OO_Patterns._7_Optional_Objects.Before
{
	public interface IWarranty
	{
		void Claim(DateTime date, Action onValidClaim = null);
	}
}
