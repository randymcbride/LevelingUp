using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Bridge.Classes
{
	public class AppAuthenticationRequest : AuthenticationRequest
	{
		public AppAuthenticationRequest(IAuthProvider authProvider, string appName) : base(authProvider)
		{
			Identifier = appName;
		}

		public override string Identifier { get; }
		public override string Credential => Token;
		public string Token { get; set; }

		public override void Authenticate()
		{
			authProvider.Authenticate(this);
		}
	}
}
