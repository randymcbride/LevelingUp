using OO_Patterns.Looping;
using OO_Patterns.Looping.After;
using System.Collections.Generic;
using System.Linq;

namespace OO_Patterns.Sequence_Class_and_Composites.Before
{
	public static class PaintJobEstimator
	{
		public static Painter SelectCheapestPainter(double squareFeet, IEnumerable<Painter> painters) =>
			painters.Where(painter => painter.IsAvailable).WithMinimum(painter => painter.GetCostEstimate(squareFeet));

		public static Painter SelectFastestPainter(double squareFeet, IEnumerable<Painter> painters) =>
			painters.Where(painter => painter.IsAvailable).WithMinimum(Painter => Painter.GetTimeEstimate(squareFeet));

		public static IPainter WorkTogether(double squareFeet, IEnumerable<Painter> painters)
		{
			double totalHours = 1/painters
				.Where(p => p.IsAvailable)
				.Select(p => 1 / p.GetTimeEstimate(squareFeet).TotalHours)
				.Sum();

			double totalCost = painters
				.Where(p => p.IsAvailable)
				.Select(p => p.HourlyRate * totalHours)
				.Sum();

			return new PainterGroup
			{
				HourlyRate = totalCost / totalHours,
				HoursPerSquareFoot = totalHours / squareFeet
			};
		}
	}
}
