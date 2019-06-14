using Microsoft.VisualStudio.TestTools.UnitTesting;
using OO_Patterns.Looping;
using OO_Patterns.Looping.Before;
using System;
using System.Collections.Generic;
using System.Text;

namespace OO_Patterns_Tests.Looping
{
	[TestClass]
	public class LoopingBeforeTests
	{
		[TestMethod]
		public void GetsCheapestPainter()
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
	}
}
