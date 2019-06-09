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
			var expensivePainter = new Painter { Rate = 100, IsAvailable = true };
			var cheapPainter = new Painter { Rate = 50, IsAvailable = true };
			var unavailablePainter = new Painter { Rate = 40, IsAvailable = false };
			var painters = new List<Painter>
			{
				expensivePainter, cheapPainter, unavailablePainter
			};
			var cheapestAvailable = PaintJobEstimator.SelectCheapestPainter(100, painters);

			Assert.AreEqual(cheapestAvailable, cheapPainter);
		}
	}
}
