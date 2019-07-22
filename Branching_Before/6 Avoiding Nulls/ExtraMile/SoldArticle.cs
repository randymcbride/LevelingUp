using System;

namespace OO_Patterns._6_Avoiding_Nulls.ExtraMile
{
	public class SoldArticle
	{
		private DateTime sellDate;

		public IWarranty Warranty { get; private set; }
		public SoldArticle()
		{
			sellDate = DateTime.Now;
		}

		public void InGoodCondition(bool isGoodCondition)
		{
			if (isGoodCondition)
				Warranty = new TimeWarranty(sellDate, TimeSpan.FromDays(365));
			else
				Warranty = new VoidWarranty();
		}
	}
}
