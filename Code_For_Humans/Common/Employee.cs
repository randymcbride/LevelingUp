using System;

namespace Code_For_Humans.Common
{
	public class Employee
	{
		public EmployeeType Type { get; set; }
		public string Name { get; set; }
		public string BadTypeExample { get; set; }
		public int Age { get; set; }
		public DateTime HireDate { get; set; }
		public DateTime? TerminationDate { get; set;}

		internal bool IsEligibleForPension(DateTime? onDate = null)
		{
			onDate = onDate ?? DateTime.Now;
			return !TerminationDate.HasValue
				&& onDate - HireDate > TimeSpan.FromDays(365 * 10)
				&& Age > 65;
		}
	}
}
