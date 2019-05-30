using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceSegregration
{
	public class EmailNotifier : INotifier
	{
		public void SendEmail()
		{
			//emailSender.SendEmail()
		}

		public void SendText()
		{
			throw new NotImplementedException();
		}
	}
}
