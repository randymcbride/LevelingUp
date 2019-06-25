namespace OO_Patterns._5_Imutable_Objects.Before
{
	public class MoneyAmount
	{
		public decimal Amount { get; set; }
		public string CurrencySymbol { get; set; }

		public override string ToString() => $"{CurrencySymbol}{Amount}";
	}
}
