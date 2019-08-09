using System;

namespace OO_Patterns._9_Replace_branching_with_Rule_Chains.Rules
{
	public class NoClaimRule : IWarrantyRules
	{
		public Action<Action> Claim => action => { };

		public void CircuitryFailed()
		{
		}

		public void CircuitryOperational()
		{
		}

		public void NotOperational()
		{
		}

		public void Operational()
		{
		}

		public void VisiblyDamaged()
		{
		}
	}
}