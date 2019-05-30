using System;
using System.Collections.Generic;

/*
 * The LSP_After project does not violate LSP because the different types of employees are each substituitable for
 * the base type, which in this case is IPayableEmployee. This is evident by the fact that the PayrollEngine no longer
 * cares what type each employee instance is. Now that our classes follow LSP, the PayrollEngine.Process method is trivial.
 */

namespace LSP_After
{
	class Program
	{
		static void Main(string[] args)
		{
			var wageWorker = new Employee { Name = "John Doe", Wage = 20.00M };
			var salaryWorker = new SalariedEmployee { Name = "Jane Doe", Wage = 60000.00M };
			var staff = new List<IPayableEmployee> { wageWorker, salaryWorker };
			var payrollEngine = new PayrollEngine();
			var totalPayroll = payrollEngine.Process(staff);
			Console.WriteLine($"Total payroll for the pay period is {totalPayroll}");
		}
	}
}
