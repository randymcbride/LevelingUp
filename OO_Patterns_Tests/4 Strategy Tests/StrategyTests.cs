using Microsoft.VisualStudio.TestTools.UnitTesting;
using OO_Patterns._4_Turning_Algorithms_into_strategy_objects;
using OO_Patterns.Strategies;
using System.Collections.Generic;

namespace OO_Patterns_Tests._4_Strategy_Tests
{
	[TestClass]
	public class StrategyTests
	{
		private ProportionalPainter expensivePainter;
		private ProportionalPainter cheapPainter;
		private ProportionalPainter unavailablePainter;
		private Painters<ProportionalPainter> painters;

		[TestInitialize]
		public void Setup()
		{
			expensivePainter = new ProportionalPainter { HourlyRate = 100, IsAvailable = true, SquareFeetPerHour = 400 };
			cheapPainter = new ProportionalPainter { HourlyRate = 10, IsAvailable = true, SquareFeetPerHour = 200 };
			unavailablePainter = new ProportionalPainter { HourlyRate = 40, IsAvailable = false, SquareFeetPerHour = 200 };
			var paintersList = new List<ProportionalPainter>
			{
				expensivePainter, cheapPainter, unavailablePainter
			};
			painters = new Painters<ProportionalPainter>(paintersList);
		}
		[TestMethod]
		public void CreatesProperPainterGroup()
		{

			var painterGroup = painters.WorkTogether(1000, new ProportionalPaintingScheduleStrategy());

			Assert.IsTrue(painterGroup.GetCostEstimate(1000) - 183.33 < 0.1);
		}
	}
}
