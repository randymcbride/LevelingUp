using System;
using System.Collections.Generic;
using System.Text;

namespace OO_Patterns._9_Replace_branching_with_Rule_Chains.Rules
{
	public class CircuitryFailedRule : ChainedRule
	{
		private Action<Action> claimAction;

		public CircuitryFailedRule(Action<Action> actionClaim, IWarrantyRules next) : base(next)
		{
			this.claimAction = actionClaim;
		}

		public override void HandleCircuitryFailed()
		{
			Claim = claimAction;
		}

		public override void HandleCircuitryOperational()
		{
			Claim = Forward;
		}
	}
}
