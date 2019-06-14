using System;

namespace OO_Patterns.Looping
{
	public class Painter : IPainter
	{
		public bool IsAvailable { get; set; }
		public double HourlyRate { get; set; }
		public double SquareFeetPerHour { get; set; }
		public TimeSpan GetTimeEstimate(double squareFeet) => TimeSpan.FromHours(squareFeet / SquareFeetPerHour);
		public double GetCostEstimate(double squareFeet) => GetTimeEstimate(squareFeet).TotalHours * HourlyRate;
	}
}
