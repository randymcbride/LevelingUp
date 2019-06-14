using Microsoft.VisualStudio.TestTools.UnitTesting;
using OO_Patterns.Looping;
using OO_Patterns.Sequence_Class_and_Composites.Before;
using System.Collections.Generic;

namespace OO_Patterns_Tests._3_Tests___Avoid_Loopint_with_Sequence_Class_and_Composition
{
	[TestClass]
	public class BeforeTests
	{
		[TestMethod]
		public void PaintJobEstimator_SelectsTheCheapestPainter()
		{
			var expensivePainter = new Painter { HourlyRate = 100, IsAvailable = true, SquareFeetPerHour = 200 };
			var cheapPainter = new Painter { HourlyRate = 50, IsAvailable = true, SquareFeetPerHour = 200 };
			var unavailablePainter = new Painter { HourlyRate = 40, IsAvailable = false, SquareFeetPerHour = 200 };
			var painters = new List<Painter>
			{
				expensivePainter, cheapPainter, unavailablePainter
			};
			var cheapestAvailable = PaintJobEstimator.SelectCheapestPainter(100, painters);

			Assert.AreEqual(cheapestAvailable, cheapPainter);
		}

		[TestMethod]
		public void PaintJobEstimator_SelectsTheFastestPainter()
		{
			var fastPainter = new Painter { HourlyRate = 100, IsAvailable = true, SquareFeetPerHour = 200 };
			var cheapPainter = new Painter { HourlyRate = 50, IsAvailable = true, SquareFeetPerHour = 100 };
			var unavailablePainter = new Painter { HourlyRate = 40, IsAvailable = false, SquareFeetPerHour = 300 };
			var painters = new List<Painter>
			{
				fastPainter, cheapPainter, unavailablePainter
			};
			var fastestAvailable = PaintJobEstimator.SelectFastestPainter(100, painters);

			Assert.AreEqual(fastestAvailable, fastPainter);
		}

		[TestMethod]
		public void PaintJobEstimator_CreatesProperPainterGroup()
		{
			var fastPainter = new Painter { HourlyRate = 10, IsAvailable = true, SquareFeetPerHour = 100 };
			var cheapPainter = new Painter { HourlyRate = 20, IsAvailable = true, SquareFeetPerHour = 200 };
			var unavailablePainter = new Painter { HourlyRate = 40, IsAvailable = false, SquareFeetPerHour = 300 };
			var painters = new List<Painter>
			{
				fastPainter, cheapPainter, unavailablePainter
			};
			var painterGroup = PaintJobEstimator.WorkTogether(1000, painters);

			Assert.AreEqual(100, painterGroup.GetCostEstimate(1000));
		}
	}
}
