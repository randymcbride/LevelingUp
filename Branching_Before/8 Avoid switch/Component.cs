using System;

namespace OO_Patterns._8_Avoid_switch
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
