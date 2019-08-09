using System;
using System.Collections.Generic;
using System.Text;

namespace OO_Patterns._9_Replace_branching_with_Rule_Chains.Rules
{
	public static class DefaultWarrantyRulesFactory
	{
		public static IWarrantyRules Create(Action<Action> circuitryClaim,
			Action<Action> moneyBackClaim,
			Action<Action> notOperationalClaim) =>
			
				new NotOperationalRule(notOperationalClaim,
					new CircuitryFailedRule(circuitryClaim,
						new MoneyBackRule(moneyBackClaim, 
							new NoClaimRule())
					)
				);
	}
}
