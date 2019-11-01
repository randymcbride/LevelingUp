namespace DesignPatterns.Bridge.Classes
{
	public interface IAuthProvider
	{
		void Authenticate(AuthenticationRequest entity);
	}
}