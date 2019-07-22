using System;

namespace OO_Patterns._6_Avoiding_Nulls.Before
{
	public class SoldArticle
	{
		public Warranty MoneyBack { get; }
		public SoldArticle(Warranty moneyBack)
		{
			MoneyBack = moneyBack;
		}
		public bool CanBeReturned { get => MoneyBack.IsValidOn(DateTime.Now); }
	}
}
