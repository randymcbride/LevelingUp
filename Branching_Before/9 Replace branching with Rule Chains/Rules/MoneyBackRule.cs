using System;

namespace OO_Patterns._9_Replace_branching_with_Rule_Chains.Rules
{
	public class MoneyBackRule : ChainedRule
	{
		private Action<Action> actionClaim;

		public MoneyBackRule(Action<Action> actionClaim, IWarrantyRules next) : base(next)
		{
			Claim = actionClaim;
		}

		public override void HandleNotOperational()
		{
			Claim = Forward;
		}
		public override void HandleCircuitryFailed()
		{
			Claim = Forward;
		}
		public override void HandleVisiblyDamaged()
		{
			Claim = Forward;
		}
	}
}
