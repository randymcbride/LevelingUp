using System.Security.Authentication;

namespace DesignPatterns.Bridge.Classes
{
	public class TokenAuthProvider : IAuthProvider
	{
		private IAppRepo appRepo;

		public TokenAuthProvider(IAppRepo appRepo)
		{
			this.appRepo = appRepo;
		}
		public void Authenticate(AuthenticationRequest entity)
		{
			var app = appRepo.Get(entity.Identifier) ?? throw new UnknownEntityException();
			if (app.Token != entity.Credential)
				throw new InvalidCredentialException();
		}
	}
}
