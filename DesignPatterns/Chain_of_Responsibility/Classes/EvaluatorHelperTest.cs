using DesignPatterns.Chain_of_Responsibility.Classes.HandEvaluatorChain;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace DesignPatterns.Chain_of_Responsibility.Classes
{
	[TestClass]
	public class EvaluatorHelperTest
	{
		[TestMethod]
		public void GroupsCardsByValue()
		{
			var hand = new List<Card> { new Card("H", "3"), new Card("H", "3"), new Card("H", "1") };
			var groupings = EvaluatorHelper.GroupByValue(hand);
			Assert.AreEqual(2, groupings.Count);
		}
	}
}
