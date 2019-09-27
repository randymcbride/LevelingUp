using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_For_Humans.Common
{
	public class InactiveUser : BasicUser
	{
		public override void Login()
		{
			Debug.WriteLine("Unable to login user. They are inactive");
		}

		public ActiveUser Activate() => new ActiveUser(this);
	}
}
