using OO_Patterns._7_Optional_Objects.After;
using System;

namespace OO_Patterns._8_Avoid_switch.Before
{
	public class SoldArticle
	{
		private DateTime sellDate;

		private Maybe<Component> Circuitry { get; set; }
		public IWarranty MoneyBackWarranty { get; private set; }
		private IWarranty FailedCircuitryWarranty { get; set; }
		private IWarranty CircuitryWarranty { get; set; }
		private IWarranty NotOperationalWarranty { get; set; }
		private OperationalStateEnum OperationalStatus { get; set; }

		public SoldArticle()
		{
			sellDate = DateTime.Now;
			MoneyBackWarranty = new TimeWarranty(DateTime.Now, TimeSpan.FromDays(365));
			CircuitryWarranty = new VoidWarranty();
			Circuitry = Maybe<Component>.None();
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

		public void ClaimCircuitryWarranty(Action onValidClaim)
		{
			Circuitry.Do(c => CircuitryWarranty.Claim(c.DefectDetectedOn, onValidClaim));
		}

		public void VisibleDamage()
		{
			OperationalStatus |= OperationalStateEnum.VisibleDamage;
		}

		public void NotOperational()
		{
			OperationalStatus |= OperationalStateEnum.NotOperational;
		}

		public void Repaired()
		{
			OperationalStatus &= ~OperationalStateEnum.NotOperational;
		}

		public void ClaimWarranty(DateTime claimDate, Action onValidClaim = null)
		{
			switch (OperationalStatus)
			{
				case OperationalStateEnum.FullyOperational:
					MoneyBackWarranty.Claim(claimDate, onValidClaim);
					break;
				case OperationalStateEnum.NotOperational:
				case OperationalStateEnum.NotOperational | OperationalStateEnum.VisibleDamage:
				case OperationalStateEnum.NotOperational | OperationalStateEnum.BrokenCircuitry:
				case OperationalStateEnum.NotOperational | OperationalStateEnum.BrokenCircuitry | OperationalStateEnum.VisibleDamage:
					NotOperationalWarranty.Claim(claimDate, onValidClaim);
					break;
				case OperationalStateEnum.VisibleDamage:
					break;
				case OperationalStateEnum.BrokenCircuitry:
				case OperationalStateEnum.VisibleDamage | OperationalStateEnum.BrokenCircuitry:
					Circuitry.Do(c => CircuitryWarranty.Claim(c.DefectDetectedOn, onValidClaim));
					break;
				default:
					break;
			}
		}
	}
}
