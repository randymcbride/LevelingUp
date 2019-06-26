namespace OO_Patterns._5_Imutable_Objects.After
{
	public class MoneyAmount
	{
		public decimal Amount { get; private set; }
		public string CurrencySymbol { get; }

		public MoneyAmount(decimal amount, string currencySymbol)
		{
			Amount = amount;
			CurrencySymbol = currencySymbol;
		}

		public override string ToString() => $"{CurrencySymbol}{Amount}";
		public MoneyAmount Increment(decimal increment) => new MoneyAmount(Amount += increment, CurrencySymbol);
		public MoneyAmount Multiply(decimal factor) => new MoneyAmount(Amount *= factor, CurrencySymbol);
	}
}
