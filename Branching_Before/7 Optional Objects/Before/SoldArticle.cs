using System;

namespace OO_Patterns._7_Optional_Objects.Before
{
	public class SoldArticle
	{
		private DateTime sellDate;

		public IWarranty Warranty { get; private set; }
		private Component Circuitry { get; set; }
		private IWarranty FailedCircuitryWarranty { get; set; }
		private IWarranty CircuitryWarranty { get; set; }


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
			Circuitry.MarkDefective(detectedOn);
			CircuitryWarranty = FailedCircuitryWarranty;
		}

		public void InstallCircuitry(Component circuitry, IWarranty extendedWarranty)
		{
			Circuitry = circuitry;
			FailedCircuitryWarranty = extendedWarranty;
		}

		public void ClaimCircuitryWarranty(Action onValidClaim)
		{
			CircuitryWarranty.Claim(Circuitry.DefectDetectedOn, onValidClaim);
		}
	}
}
