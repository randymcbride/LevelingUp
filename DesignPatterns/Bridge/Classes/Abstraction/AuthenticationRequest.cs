namespace DesignPatterns.Bridge.Classes
{
	public abstract class AuthenticationRequest
	{
		protected IAuthProvider authProvider;

		public AuthenticationRequest(IAuthProvider authProvider)
		{
			this.authProvider = authProvider;
		}
		public abstract string Identifier { get; }
		public abstract string Credential { get; }
		public abstract void Authenticate();
	}
}
