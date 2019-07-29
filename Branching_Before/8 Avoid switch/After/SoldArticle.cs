using OO_Patterns._7_Optional_Objects.After;
using OO_Patterns._8_Avoid_switch.After;
using System;
using System.Collections.Generic;

namespace OO_Patterns._8_Avoid_switch.Ater
{
	class SoldArticle
	{
		private DateTime sellDate;

		private Maybe<Component> Circuitry { get; set; }
		public IWarranty MoneyBackWarranty { get; private set; }
		private IWarranty FailedCircuitryWarranty { get; set; }
		private IWarranty CircuitryWarranty { get; set; }
		private IWarranty NotOperationalWarranty { get; set; }
		private DeviceStatus DeviceStatus { get; set; }
		private IReadOnlyDictionary<DeviceStatus, Action<Action>> WarrantyMap { get; }

		public SoldArticle(IWarrantyMap warrantyRules)
		{
			sellDate = DateTime.Now;
			MoneyBackWarranty = new TimeWarranty(DateTime.Now, TimeSpan.FromDays(365));
			CircuitryWarranty = new VoidWarranty();
			Circuitry = Maybe<Component>.None();
			WarrantyMap = warrantyRules.Create(ClaimMoneyBack, ClaimNotOperational, ClaimCircuitry);
		}

		private void ClaimNotOperational(Action onValidClaim)
		{
			NotOperationalWarranty.Claim(DateTime.Now, onValidClaim);
		}

		private void ClaimMoneyBack(Action onValidClaim)
		{
			MoneyBackWarranty.Claim(DateTime.Now, onValidClaim);
		}

		public void CircuitryNotOperational(DateTime detectedOn)
		{
			Circuitry.Do(c =>
			{
				c.MarkDefective(detectedOn);
				CircuitryWarranty = FailedCircuitryWarranty;
			});
		}

		public void InstallCircuitry(Component circuitry, IWarranty extendedWarranty)
		{
			Circuitry = Maybe<Component>.Some(circuitry);
			FailedCircuitryWarranty = extendedWarranty;
		}

		public void ClaimCircuitry(Action onValidClaim)
		{
			Circuitry.Do(c => CircuitryWarranty.Claim(c.DefectDetectedOn, onValidClaim));
		}

		public void VisibleDamage()
		{
			DeviceStatus = DeviceStatus.WithVisibleDamage();
		}

		public void NotOperational()
		{
			DeviceStatus = DeviceStatus.NotOperational();
		}

		public void Repaired()
		{
			DeviceStatus = DeviceStatus.Repaired();
		}

		public void ClaimWarranty(Action onValidClaim = null)
		{
			WarrantyMap[DeviceStatus](onValidClaim);
		}
	}
}
