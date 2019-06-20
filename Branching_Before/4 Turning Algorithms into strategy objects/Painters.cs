using OO_Patterns.Looping;
using OO_Patterns.Looping.After;
using OO_Patterns.Sequence_Class_and_Composites.After;
using System.Collections.Generic;
using System.Linq;

namespace OO_Patterns.Strategies
{
	public class Painters<TPainter> where TPainter : IPainter
	{
		public Painters(IEnumerable<TPainter> painters)
		{
			PaintersSequence = painters;
		}

		public IEnumerable<TPainter> PaintersSequence { get; }

		public Painters<TPainter> GetAvailable() => new Painters<TPainter>(PaintersSequence.Where(p => p.IsAvailable));

		public TPainter GetCheapest(double squareFeet) => PaintersSequence.WithMinimum(p => p.GetCostEstimate(squareFeet));

		public TPainter GetFastest(double squareFeet) => PaintersSequence.WithMinimum(p => p.GetTimeEstimate(squareFeet));

		public PainterGroup WorkTogether(double squareFeet, IPainterScheduler<TPainter> scheduler)
		{
			var paintingTasks = scheduler.Schedule(squareFeet, PaintersSequence);

			var totalHours = paintingTasks.Max(pt => pt.Painter.GetTimeEstimate(pt.SquareFeet)).TotalHours;

			var totalCost = paintingTasks.Sum(pt => pt.Painter.GetCostEstimate(pt.SquareFeet));

			return new PainterGroup
			{
				HourlyRate = totalCost / totalHours,
				HoursPerSquareFoot = totalHours / squareFeet
			};
		}
	}
}
