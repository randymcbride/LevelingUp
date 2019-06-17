using OO_Patterns.Looping;
using OO_Patterns.Looping.After;
using OO_Patterns.Sequence_Class_and_Composites.After;
using System.Collections.Generic;
using System.Linq;

namespace OO_Patterns._3_Avoid_Looping_with_Sequence_Class_and_Composites.After
{
	public class Painters
	{
		public Painters(IEnumerable<Painter> painters)
		{
			PaintersSequence = painters;
		}

		public IEnumerable<Painter> PaintersSequence { get; }

		public Painters GetAvailable() => new Painters(PaintersSequence.Where(p => p.IsAvailable));

		public Painter GetCheapest(double squareFeet) => PaintersSequence.WithMinimum(p => p.GetCostEstimate(squareFeet));

		public Painter GetFastest(double squareFeet) => PaintersSequence.WithMinimum(p => p.GetTimeEstimate(squareFeet));

		public PainterGroup WorkTogether(double squareFeet)
		{
			double totalHours = 1 / PaintersSequence
				.Where(p => p.IsAvailable)
				.Select(p => 1 / p.GetTimeEstimate(squareFeet).TotalHours)
				.Sum();

			double totalCost = PaintersSequence
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
