using System.Collections.Generic;

namespace DesignPatterns.Chain_of_Responsibility.Classes.HandEvaluatorChain
{
	public static class EvaluatorHelper
	{
		public static Dictionary<string, int> GroupByValue(ICollection<Card> hand)
		{
			var groupings = new Dictionary<string, int>();
			foreach (var card in hand)
			{
				if (!groupings.ContainsKey(card.Value))
					groupings.Add(card.Value, 1);
				else
					groupings[card.Value]++;
			}
			return groupings;
		}
	}
}
