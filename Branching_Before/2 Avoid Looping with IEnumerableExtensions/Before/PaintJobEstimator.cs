using System.Collections.Generic;

namespace OO_Patterns.Looping.Before
{
	public static class PaintJobEstimator
	{
		public static Painter SelectCheapestPainter(double squareFeet, IEnumerable<Painter> painters)
		{
			Painter best = null;
			double bestPrice = double.MaxValue;
			foreach (var painter in painters)
			{
				if (painter.IsAvailable)
				{
					if (painter.GetCostEstimate(squareFeet) < bestPrice)
					{
						best = painter;
					}
				}
			}
			return best;
		}
	}
}
