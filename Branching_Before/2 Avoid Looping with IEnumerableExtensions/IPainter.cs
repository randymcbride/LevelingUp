using System;

namespace OO_Patterns.Looping
{
	public interface IPainter
	{
		bool IsAvailable { get; set; }
		double HourlyRate { get; set; }
		TimeSpan GetTimeEstimate(double squareFeet);
		double GetCostEstimate(double squareFeet);
	}
}
