using DesignPatterns.Chain_of_Responsibility.Classes;
using DesignPatterns.Chain_of_Responsibility.Classes.HandEvaluatorChain;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace DesignPatterns.Chain_of_Responsibility
{
	[TestClass]
	public class Demonstration
	{
		[TestMethod]
		public void IDentifiesThreeOfAKind()
		{
			var hand = new List<Card>
			{
				new Card("H","A"),
				new Card("S","A"),
				new Card("D","A"),
				new Card("D","2"),
				new Card("C", "7")
			};

			var evaluator = new PokerHandEvaluatorChain();
			var handType = evaluator.Evaluate(hand);
			Assert.AreEqual(HandType.ThreeOfAKind, handType);
		}

		[TestMethod]
		public void IDentifiesTwoPair()
		{
			var hand = new List<Card>
			{
				new Card("H","A"),
				new Card("S","A"),
				new Card("D","2"),
				new Card("S","2"),
				new Card("C", "7")
			};

			var evaluator = new PokerHandEvaluatorChain();
			var handType = evaluator.Evaluate(hand);
			Assert.AreEqual(HandType.TwoPair, handType);
		}

		[TestMethod]
		public void IDentifiesPair()
		{
			var hand = new List<Card>
			{
				new Card("H","A"),
				new Card("S","A"),
				new Card("D","3"),
				new Card("D","2"),
				new Card("C", "7")
			};

			var evaluator = new PokerHandEvaluatorChain();
			var handType = evaluator.Evaluate(hand);
			Assert.AreEqual(HandType.Pair, handType);
		}

		[TestMethod]
		public void IdentifiesHighCard()
		{
			var hand = new List<Card>
			{
				new Card("H","A"),
				new Card("S","9"),
				new Card("D","3"),
				new Card("D","2"),
				new Card("C", "7")
			};

			var evaluator = new PokerHandEvaluatorChain();
			var handType = evaluator.Evaluate(hand);
			Assert.AreEqual(HandType.HighCard, handType);
		}
	}
}
