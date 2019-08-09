using OO_Patterns._7_Optional_Objects.After;
using OO_Patterns._9_Replace_branching_with_Rule_Chains.Rules;
using System;

namespace OO_Patterns._9_ChainRules
{
	public class SoldArticle
	{
		private DateTime sellDate;

		private Maybe<Component> Circuitry { get; set; }
		public IWarranty MoneyBackWarranty { get; private set; }
		private IWarranty FailedCircuitryWarranty { get; set; }
		private IWarranty NotOperationalWarranty { get; set; }
		private IWarrantyRules WarrantyRules { get; }

		public SoldArticle()
		{
			sellDate = DateTime.Now;
			MoneyBackWarranty = new TimeWarranty(DateTime.Now, TimeSpan.FromDays(30));
			NotOperationalWarranty = new TimeWarranty(DateTime.Now, TimeSpan.FromDays(365 * 2));
			FailedCircuitryWarranty = new TimeWarranty(DateTime.Now, TimeSpan.FromDays(365 * 2));

			Circuitry = Maybe<Component>.None();
			WarrantyRules = DefaultWarrantyRulesFactory.Create(
				ClaimCircuitry,
				ClaimMoneyBack,
				ClaimNotOperational
			);
		}

		public void Operational()
		{
			WarrantyRules.Operational();
		}

		private void ClaimNotOperational(Action onValidClaim)
		{
			NotOperationalWarranty.Claim(DateTime.Now, onValidClaim);
		}

		private void ClaimMoneyBack(Action onValidClaim)
		{
			MoneyBackWarranty.Claim(DateTime.Now, onValidClaim);
		}

		public void CircuitryNotOperational()
		{
			WarrantyRules.CircuitryFailed();
		}

		public void InstallCircuitry(Component circuitry)
		{
			Circuitry = Maybe<Component>.Some(circuitry);
		}

		public void ClaimCircuitry(Action onValidClaim)
		{
			Circuitry.Do(c => FailedCircuitryWarranty.Claim(c.DefectDetectedOn, onValidClaim));
		}

		public void VisibleDamage()
		{
			WarrantyRules.VisiblyDamaged();
		}

		public void NotOperational()
		{
			WarrantyRules.NotOperational();
		}

		public void Repaired()
		{
			WarrantyRules.Operational();
		}

		public void ClaimWarranty(Action onValidClaim = null)
		{
			WarrantyRules.Claim(onValidClaim);
		}
	}
}
