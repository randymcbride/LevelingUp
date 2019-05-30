using System;
using System.Collections.Generic;

namespace LSP_Before
{
	internal class PayrollEngine
	{
		public PayrollEngine()
		{
		}

		internal decimal Process(List<Employee> staff, int weeks = 2, int hoursPerWeek = 40)
		{
			var totalPayroll = 0M;
			foreach (var employee in staff)
			{
				if (employee is SalariedEmployee salariedEmployee)
				{
					var payPerWeek = salariedEmployee.Salary / 52;
					totalPayroll += payPerWeek * weeks;
				}
				else
				{
					totalPayroll += employee.Wage * weeks * hoursPerWeek;
				}
			}
			return totalPayroll;
		}
	}
}