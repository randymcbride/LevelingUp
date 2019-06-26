namespace OO_Patterns._5_Imutable_Objects.After
{
	public class ShopppingCart
	{
		public bool IsFlashSale { get; set; }
		public MoneyAmount Reserve(MoneyAmount cost)
		{
			if (IsFlashSale)
			{
				return cost.Multiply(.5M);
			}
			return cost;
		}
		public MoneyAmount Buy(MoneyAmount cost, MoneyAmount accountBalance)
		{
			var reservedCost = Reserve(cost);
			var enoughMoney = accountBalance.Amount >= reservedCost.Amount;
			if (enoughMoney)
			{
				return accountBalance.Increment(-reservedCost.Amount);
			}
			return accountBalance;
		}
	}
}
