using System;
using System.Collections.Generic;
using System.Text;

namespace OO_Patterns._9_Replace_branching_with_Rule_Chains.Rules
{
	public interface IWarrantyRules
	{
		void CircuitryOperational();
		void CircuitryFailed();
		void NotOperational();
		void VisiblyDamaged();
		void Operational();
		Action<Action> Claim { get; }
	}
}
