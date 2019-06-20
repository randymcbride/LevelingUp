using Microsoft.VisualStudio.TestTools.UnitTesting;
using OO_Patterns._3_Avoid_Looping_with_Sequence_Class_and_Composites.After;
using OO_Patterns.Looping;
using OO_Patterns.Sequence_Class_and_Composites.After;
using System.Collections.Generic;

namespace OO_Patterns_Tests._3_Tests___Avoid_Loopint_with_Sequence_Class_and_Composition.After
{
	[TestClass]
	public class AfterTests
	{
		private Painter expensivePainter;
		private Painter cheapPainter;
		private Painter unavailablePainter;
		private Painters painters;

		[TestInitialize]
		public void Setup()
		{
			expensivePainter = new Painter { HourlyRate = 100, IsAvailable = true, SquareFeetPerHour = 400 };
			cheapPainter = new Painter { HourlyRate = 10, IsAvailable = true, SquareFeetPerHour = 200 };
			unavailablePainter = new Painter { HourlyRate = 40, IsAvailable = false, SquareFeetPerHour = 200 };
			var paintersList = new List<Painter>
			{
				expensivePainter, cheapPainter, unavailablePainter
			};
			painters = new Painters(paintersList);
		}

		[TestMethod]
		public void SelectsTheCheapestPainter()
		{
			var cheapestAvailable = painters.GetAvailable().GetCheapest(1000);

			Assert.AreEqual(cheapestAvailable, cheapPainter);
		}

		[TestMethod]
		public void SelectsTheFastestPainter()
		{
			var fastestAvailable = painters.GetAvailable().GetFastest(1000);

			Assert.AreEqual(fastestAvailable, expensivePainter);
		}

		[TestMethod]
		public void CreatesProperPainterGroup()
		{

			var painterGroup = painters.WorkTogether(1000);

			Assert.IsTrue(painterGroup.GetCostEstimate(1000) - 183.33 < 0.1);
		}
	}
}
