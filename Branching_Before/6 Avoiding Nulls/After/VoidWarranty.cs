using System;
using System.Collections.Generic;
using System.Text;

namespace OO_Patterns._6_Avoiding_Nulls.After
{
	public class VoidWarranty : IWarranty
	{
		public bool IsValidOn(DateTime date) => false;
	}
}
