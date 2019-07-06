namespace OO_Patterns._6_Avoiding_Nulls.Before
{
	public class SoldArticle
	{
		public Warranty MoneyBack { get; }
		public Warranty Express { get; }
		public SoldArticle(Warranty moneyBack, Warranty express)
		{
			MoneyBack = moneyBack;
			Express = express;
		}
	}
}
