using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DesignPatterns.Composite
{
	[TestClass]
	public class Demonstration
	{
		[TestMethod]
		public void Demo()
		{
			//My portfolio consists of two shares of the NASDAQ, one share of Berkshire Hataway, and an additional one share of AAPL
			//This is an extreme simplification but it demonstrates the composite pattern. Notice I technically have 3 shares of AAPL
			//Two shares from each of my NDX and then an additional share. The tree of my porfolio would look like this
			/*
			 *								 --AAPL
			 *					 --NDX-| 
			 *					 |     --AMZN
									 |		 --AAPL
			 *					 --NDX-| 
			 *					 |     --AMZN
			 * Portfolio-|
			 *					 |
			 *					 --BRKA
			 *					 |
			 *					 --AAPL
			 * 
			 */
			var myPortfolio = new Basket { Assets = { NDX, NDX, BRKA, AAPL } };

			//notice that calcualting the value/return of the root, branch, and leaf is all the same inteface.
			//It doesn't matter how deep or shallow the structure is, it just works. That is the value of the composite pattern.
			Assert.AreEqual(3000m, myPortfolio.Value);
			Assert.AreEqual(600M, NDX.Value);
			Assert.AreEqual(400M, AAPL.Value);

			Assert.AreEqual(0m, myPortfolio.Return(new DateTime(2018, 1, 1), new DateTime(2018, 1, 1)));
			Assert.AreEqual(0m, NDX.Return(new DateTime(2018, 1, 1), new DateTime(2019, 1, 1)));
			Assert.AreEqual(100m, AAPL.Return(new DateTime(2018, 1, 1), new DateTime(2019, 1, 1)));
		}
		
		[TestInitialize]
		public void Initialize()
		{
			aaplValuations = new List<Valuation>
			{
				new Valuation("2016-01-01", 100m),
				new Valuation("2017-01-01", 200m),
				new Valuation("2018-01-01", 300m),
				new Valuation("2019-01-01", 400m)
			};
			amznValuations = new List<Valuation>
			{
				new Valuation("2016-01-01", 300m),
				new Valuation("2017-01-01", 200m),
				new Valuation("2018-01-01", 300m),
				new Valuation("2019-01-01", 200m)
			};
			brkaValuations = new List<Valuation>
			{
				new Valuation("2016-01-01", 1000m),
				new Valuation("2017-01-01", 700m),
				new Valuation("2018-01-01", 1200m),
				new Valuation("2019-01-01", 1400m)
			};
			AAPL = new Stock { Valuations = aaplValuations };
			AMZN = new Stock { Valuations = amznValuations };
			BRKA = new Stock { Valuations = brkaValuations };
			NDX = new Basket { Assets = { AAPL, AMZN } };
		}
		private List<Valuation> aaplValuations;
		private List<Valuation> amznValuations;
		private List<Valuation> brkaValuations;
		private Stock AAPL;
		private Stock AMZN;
		private Stock BRKA;
		private Basket NDX;
	}
}
