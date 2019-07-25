using System;

namespace OO_Patterns._7_Optional_Objects.Before
{
	public class Component
	{
		public DateTime InstallmentDate { get; }
		public DateTime DefectDetectedOn { get; set; }

		public Component(DateTime installmentDate)
		{
			InstallmentDate = installmentDate;
		}

		public void MarkDefective(DateTime withDate)
		{
			DefectDetectedOn = withDate;
		}
	}
}
