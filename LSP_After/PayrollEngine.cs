using System.Collections.Generic;
using System.Linq;

namespace LSP_After
{
	internal class PayrollEngine
	{
		public PayrollEngine()
		{
		}

		internal decimal Process(List<IPayableEmployee> staff, int weeks = 2, int hoursPerWeek = 40) =>
			staff.Sum(employee => employee.GetPay(weeks, hoursPerWeek));
	}
}