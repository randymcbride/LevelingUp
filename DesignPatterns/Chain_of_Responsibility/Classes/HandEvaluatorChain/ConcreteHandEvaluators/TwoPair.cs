using System.Collections.Generic;

namespace DesignPatterns.Chain_of_Responsibility.Classes.HandEvaluatorChain.ConcreteHandEvaluators
{
	public class TwoPairEvaluator : IHandEvaluator
	{
		private IHandEvaluator next;

		public HandType Evaluate(ICollection<Card> hand)
		{
			var groupings = EvaluatorHelper.GroupByValue(hand);
			int numberOfPairs = 0;
			foreach (var grouping in groupings)
				if (grouping.Value == 2)
					numberOfPairs++;

			if (numberOfPairs == 2)
				return HandType.TwoPair;
			else
				return next.Evaluate(hand);
		}

		public IHandEvaluator RegisterNext(IHandEvaluator next)
		{
			this.next = next;
			return next;
		}
	}
}
