using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_For_Humans.Common
{
	public abstract class BasicUser
	{
		public string Email { get; set; }
		public bool IsLoggedIn { get; set; } = false;
		public abstract void Login();
	}
}
