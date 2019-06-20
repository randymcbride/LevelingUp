using System;
using System.Collections.Generic;
using System.Linq;
using OO_Patterns.Strategies;

namespace OO_Patterns._4_Turning_Algorithms_into_strategy_objects
{
	public class ProportionalPaintingScheduleStrategy : IPainterScheduler<ProportionalPainter>
	{
		public IEnumerable<PaintingTask<ProportionalPainter>> 
			Schedule(double squareFeet, IEnumerable<ProportionalPainter> painters)
		{
			var squreFeetPerHour = painters.Sum(p => p.SquareFeetPerHour);
			var totalTime = TimeSpan.FromHours(squareFeet / squreFeetPerHour);
			return painters.Select(p => new PaintingTask<ProportionalPainter>
			{
				Painter = p,
				SquareFeet = p.SquareFeetPerHour / totalTime.TotalHours
			});
		}
	}
}
