using System;

namespace DesignPatterns.Composite
{
	public class Valuation
	{
		public Valuation(string date, decimal value)
		{
			Date = Convert.ToDateTime(date);
			Value = value;
		}
		public DateTime Date { get; set; }
		public decimal Value { get; set; }
	}
}