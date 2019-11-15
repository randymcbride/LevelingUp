using System.Collections.Generic;
using System.Linq;

namespace DesignPatterns.Chain_of_Responsibility.Classes.HandEvaluatorChain.ConcreteHandEvaluators
{
	public class PairEvaluator : IHandEvaluator
	{
		private IHandEvaluator next;

		public HandType Evaluate(ICollection<Card> hand)
		{
			var groupings = EvaluatorHelper.GroupByValue(hand);
			int pairCount = 0;
			foreach (var grouping in groupings)
				if (grouping.Value == 2)
					pairCount++;
			if (pairCount == 1)
				return HandType.Pair;
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
