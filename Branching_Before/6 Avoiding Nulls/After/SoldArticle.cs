using System;

namespace OO_Patterns._6_Avoiding_Nulls.After
{
	public class SoldArticle
	{
		public IWarranty MoneyBack { get; }
		public SoldArticle(IWarranty moneyBack)
		{
			MoneyBack = moneyBack ?? throw new ArgumentException("Cannot be null", "moneyBack");
		}
		public bool CanBeReturned { get => MoneyBack.IsValidOn(DateTime.Now); }
	}
}
