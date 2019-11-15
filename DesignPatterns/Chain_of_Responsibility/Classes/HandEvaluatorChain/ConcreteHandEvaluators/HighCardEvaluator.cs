using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Chain_of_Responsibility.Classes.HandEvaluatorChain.ConcreteHandEvaluators
{
	class HighCardEvaluator : IHandEvaluator
	{
		public HandType Evaluate(ICollection<Card> hand) => HandType.HighCard;

		public IHandEvaluator RegisterNext(IHandEvaluator next) => next;
	}
}
