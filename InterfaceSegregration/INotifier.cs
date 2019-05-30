using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceSegregration
{
	public interface INotifier
	{
		void SendEmail();
		void SendText();
	}
}
