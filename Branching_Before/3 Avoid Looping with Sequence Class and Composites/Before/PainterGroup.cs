using OO_Patterns.Looping;
using System;
using System.Collections.Generic;
using System.Text;

namespace OO_Patterns.Sequence_Class_and_Composites.Before
{
	public class PainterGroup : IPainter
	{
		public double HoursPerSquareFoot { get; set; }
		public double HourlyRate { get; set; }
		public double GetCostEstimate(double squareFeet) => GetTimeEstimate(squareFeet).TotalHours * HourlyRate;

		public TimeSpan GetTimeEstimate(double squareFeet) => TimeSpan.FromHours(HoursPerSquareFoot * squareFeet);
	}
}
