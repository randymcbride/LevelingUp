using System.Collections.Generic;

namespace DesignPatterns.Chain_of_Responsibility.Classes.HandEvaluatorChain.ConcreteHandEvaluators
{
	public class ThreeOfAKindEvaluator : IHandEvaluator
	{
		private IHandEvaluator next;

		public HandType Evaluate(ICollection<Card> hand)
		{
			var groupings = EvaluatorHelper.GroupByValue(hand);
			int numberOfSetsOfThree = 0;
			foreach (var grouping in groupings)
				if (grouping.Value == 3)
					numberOfSetsOfThree++;

			if (numberOfSetsOfThree == 1)
				return HandType.ThreeOfAKind;
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
