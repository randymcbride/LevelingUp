using OO_Patterns.Looping;
using OO_Patterns.Looping.After;
using System;
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

		public static void WorkTogether(double squareFeet, IEnumerable<Painter> painters)
		{
			//This is getting messy
			throw new NotImplementedException();
		}
	}
}
