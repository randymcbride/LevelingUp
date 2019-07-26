using System;

namespace OO_Patterns._7_Optional_Objects.After
{
	public class SoldArticle
	{
		private DateTime sellDate;

		public IWarranty Warranty { get; private set; }
		private Maybe<Component> Circuitry { get; set; } = Maybe<Component>.None();
		private IWarranty FailedCircuitryWarranty { get; set; }
		private IWarranty CircuitryWarranty { get; set; } = new VoidWarranty();


		public SoldArticle()
		{
			sellDate = DateTime.Now;
		}

		public void InGoodCondition(bool isGoodCondition)
		{
			if (isGoodCondition)
				Warranty = new TimeWarranty(sellDate, TimeSpan.FromDays(365));
			else
				Warranty = new VoidWarranty();
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
	}
}
