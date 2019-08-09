using System;
using System.Collections.Generic;
using System.Text;

namespace OO_Patterns._9_Replace_branching_with_Rule_Chains.Rules
{
	public class NotOperationalRule : ChainedRule
	{
		private Action<Action> claimAction;

		public NotOperationalRule(Action<Action> actionClaim, IWarrantyRules next) : base(next)
		{
			this.claimAction = actionClaim;
		}

		public override void HandleNotOperational()
		{
			Claim = claimAction;
		}

		public override void HandleOperational()
		{
			Claim = Forward;
		}
	}
}
