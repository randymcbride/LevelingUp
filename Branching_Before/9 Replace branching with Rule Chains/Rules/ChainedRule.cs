using System;
using System.Collections.Generic;
using System.Text;

namespace OO_Patterns._9_Replace_branching_with_Rule_Chains.Rules
{
	public class ChainedRule : IWarrantyRules
	{
		private IWarrantyRules next;

		public ChainedRule(IWarrantyRules next)
		{
			this.next = next;
		}
		public Action<Action> Claim { get; protected set;}
		protected void Forward(Action onValidClaim) => next.Claim(onValidClaim);

		public void CircuitryFailed()
		{
			HandleCircuitryFailed();
			next.CircuitryFailed();
		}

	
		public void CircuitryOperational()
		{
			HandleCircuitryOperational();
			next.CircuitryOperational();
		}

		public void NotOperational()
		{
			HandleNotOperational();
			next.NotOperational();
		}

		public void Operational()
		{
			HandleOperational();
			next.Operational();
		}

		public void VisiblyDamaged()
		{
			HandleVisiblyDamaged();
			next.VisiblyDamaged();
		}

		public virtual void HandleCircuitryFailed(){}
		public virtual void HandleCircuitryOperational(){ }
		public virtual void HandleNotOperational(){ }
		public virtual void HandleOperational(){ }
		public virtual void HandleVisiblyDamaged(){ }

	}
}
