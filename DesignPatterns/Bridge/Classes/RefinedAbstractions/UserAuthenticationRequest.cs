namespace DesignPatterns.Bridge.Classes
{
	public class UserAuthenticationRequest : AuthenticationRequest
	{
		public UserAuthenticationRequest(IAuthProvider authProvider) : base(authProvider)
		{
		}

		public string UserName { get; set; }
		public string Password { get; set; }
		public override string Identifier => UserName;
		public override string Credential => Password;

		public override void Authenticate()
		{
			authProvider.Authenticate(this);
		}
	}
}
