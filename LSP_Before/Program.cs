using System;
using System.Collections.Generic;

/*
 * The Lsikov Substitution Principle states that derived classes should be substitutable for
 * their base class. This takes the commonly found 'is a' relationship a step further. We don't just want
 * 'is a', we want 'is a and can be treated like a' relationships.
 * 
 * The SalariedWorker violates LSP because it cannot be substituted for Employee. This fact becomes
 * evident in the PayrollEngine.Process method. The method takes a list of employee objects. For each employee
 * it needs to check what type it is becuase it handle them differently. Any time we check the type of an object,
 * there is a good chance the object breaks LSP.
 * 
 * There are a couple of ways to fix this. The one that makes the most sense is to add an interface that ensures
 * an instance of employee knows how to calculate its own payroll. We will do this with an interface called IPayable.
 */

namespace LSP_Before
{
	class Program
	{
		static void Main(string[] args)
		{
			var wageWorker = new Employee { Name = "John Doe", Wage = 20.00M };
			var salaryWorker = new SalariedEmployee { Name = "Jane Doe", Salary = 60000.00M };
			var staff = new List<Employee> { wageWorker, salaryWorker };
			var payrollEngine = new PayrollEngine();
			var totalPayroll = payrollEngine.Process(staff);
			Console.WriteLine($"Total payroll for the pay period is {totalPayroll}");
		}
	}
}
