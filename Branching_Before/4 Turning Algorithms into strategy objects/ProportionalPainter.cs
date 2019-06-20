using System;
using OO_Patterns.Looping;

namespace OO_Patterns._4_Turning_Algorithms_into_strategy_objects
{
	public class ProportionalPainter : IPainter
	{
		public bool IsAvailable { get; set; }
		public double HourlyRate { get; set; }
		public double SquareFeetPerHour { get; set; }

		public double GetCostEstimate(double squareFeet)
		{
			return GetTimeEstimate(squareFeet).TotalHours * HourlyRate;
		}

		public TimeSpan GetTimeEstimate(double squareFeet)
		{
			return TimeSpan.FromHours(squareFeet / SquareFeetPerHour);
		}
	}
}
