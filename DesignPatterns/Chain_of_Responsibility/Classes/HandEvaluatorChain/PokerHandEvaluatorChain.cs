using DesignPatterns.Chain_of_Responsibility.Classes.HandEvaluatorChain.ConcreteHandEvaluators;
using System.Collections.Generic;

namespace DesignPatterns.Chain_of_Responsibility.Classes.HandEvaluatorChain
{
	public class PokerHandEvaluatorChain
	{
		IHandEvaluator handEvaluator;
		public PokerHandEvaluatorChain()
		{
			handEvaluator = new ThreeOfAKindEvaluator();
			handEvaluator
				.RegisterNext(new TwoPairEvaluator())
				.RegisterNext(new PairEvaluator())
				.RegisterNext(new HighCardEvaluator());
		}

		public HandType Evaluate(ICollection<Card> hand) => handEvaluator.Evaluate(hand);
	}
}
