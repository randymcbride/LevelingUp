namespace LSP_After
{
	public class SalariedEmployee : IPayableEmployee
	{
		public string Name { get; set; }
		public decimal Wage { get; set; }

		public decimal GetPay(int weeks, int hours)
		{
			return Wage / 52 * weeks;
		}
	}
}
