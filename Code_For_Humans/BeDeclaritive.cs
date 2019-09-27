using Code_For_Humans.Common.Basketball;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace Code_For_Humans
{
	[TestClass]
	public class BeDeclaritive
	{
		private List<PlayerGameStatistic> statistics;

		[TestMethod]
		public void ProceduralCodeIsDirty()
		{
			//this is hard to read. The code does not express what it is doing very will
			int maxRebounds = int.MinValue;
			string highestRebounder = string.Empty;
			foreach(var stat in statistics)
			{
				if(stat.Rebounds > maxRebounds)
				{
					maxRebounds = stat.Rebounds;
					highestRebounder = stat.PlayerName;
				}
			}
			Assert.AreEqual("Rudy Gobert", highestRebounder);
		}

		[TestMethod]
		public void UseExtensionMethodIsBetter()
		{
			//when you read this code you know exactly what it does
			var highestRebounder = statistics.WithMax(s => s.Rebounds);
			Assert.AreEqual("Rudy Gobert", highestRebounder.PlayerName);
		}

		[TestMethod]
		public void UseAClassIsBest()
		{
			//Here we go, this is where OO programming shines. 
			//All that ugly logic is encapsulated inside other classes that specialize in doing one thing.
			//Notice how the class builds off of the extension methods so even they are declaritive.
			//The ugly code is nestled down deep where no one will need to see it.
			//This code could not be any more expressive. The signal to noise ratio is as high as it can be
			var boxScore = new BoxScore(statistics);
			Assert.AreEqual("Donovan Mitchell", boxScore.PointLeader.PlayerName);
			Assert.AreEqual("Michael Conley", boxScore.AssistLeader.PlayerName);
			Assert.AreEqual("Rudy Gobert", boxScore.ReboundLeader.PlayerName);
		}

		[TestInitialize]
		public void Setup()
		{
			statistics = new List<PlayerGameStatistic>
			{
				new PlayerGameStatistic
				{
					PlayerName = "Donovan Mitchell",
					Assists = 7,
					Points = 20,
					Rebounds = 5
				},
				new PlayerGameStatistic
				{
					PlayerName = "Rudy Gobert",
					Assists = 3,
					Points = 14,
					Rebounds = 15
				},
				new PlayerGameStatistic
				{
					PlayerName = "Michael Conley",
					Assists = 11,
					Points = 16,
					Rebounds = 4
				}
			};
		}
	}
}
