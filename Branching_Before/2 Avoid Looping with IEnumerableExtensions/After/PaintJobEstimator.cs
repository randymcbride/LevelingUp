using System.Collections.Generic;
using System.Linq;

namespace OO_Patterns.Looping.After
{
	public static class PaintJobEstimator
	{
		public static Painter SelectCheapestPainter(double sqaureFeet, IEnumerable<Painter> painters) =>
			painters.Where(painter => painter.IsAvailable).WithMinimum(painter => painter.GetCostEstimate(sqaureFeet));
	}
}
