using System;

namespace OO_Patterns.Looping
{
	public interface IPainter
	{
		TimeSpan GetTimeEstimate(double squareFeet);
		double GetCostEstimate(double squareFeet);
	}
}
