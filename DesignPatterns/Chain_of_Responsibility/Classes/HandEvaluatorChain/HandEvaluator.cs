using System;
using System.Collections.Generic;

namespace DesignPatterns.Chain_of_Responsibility.Classes.HandEvaluatorChain
{
	public interface IHandEvaluator
	{
		IHandEvaluator RegisterNext(IHandEvaluator next);
		HandType Evaluate(ICollection<Card> hand);
	}
}
