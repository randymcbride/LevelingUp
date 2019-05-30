namespace LSP_After
{
	public class Employee : IPayableEmployee
	{
		public string Name { get; set; }
		public decimal Wage { get; set; }

		public decimal GetPay(int weeks = 2, int hours = 40)
		{
			return Wage * hours;
		}
	}
}
