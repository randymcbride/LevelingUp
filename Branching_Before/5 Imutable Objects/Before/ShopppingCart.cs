namespace OO_Patterns._5_Imutable_Objects.Before
{
	public class ShopppingCart
	{
		public bool IsFlashSale { get; set; }
		public void Reserve(MoneyAmount cost)
		{
			if (IsFlashSale)
			{
				cost.Amount *= .5M;
			}
		}
		public void Buy(MoneyAmount cost, MoneyAmount accountBalance)
		{
			var enoughMoney = accountBalance.Amount >= cost.Amount;
			Reserve(cost);
			if (enoughMoney)
			{
				accountBalance.Amount -= cost.Amount;
			}
		}
	}
}
