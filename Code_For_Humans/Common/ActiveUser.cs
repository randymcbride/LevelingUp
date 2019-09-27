using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_For_Humans.Common
{
	public class ActiveUser : BasicUser
	{
		public ActiveUser(InactiveUser inactiveUser)
		{
			Email = inactiveUser.Email;
		}

		public override void Login()
		{
			IsLoggedIn = true;
		}
	}
}
