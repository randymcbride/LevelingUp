namespace LSP_After
{
	public interface IPayableEmployee
	{
		string Name { get; set; }
		decimal Wage { get; set; }
		decimal GetPay(int weeks, int hours);
	}
}
