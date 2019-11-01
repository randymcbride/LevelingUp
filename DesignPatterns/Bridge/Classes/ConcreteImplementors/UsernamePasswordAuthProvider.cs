using System;
using System.Collections.Generic;
using System.Security.Authentication;
using System.Text;

namespace DesignPatterns.Bridge.Classes
{
	public class UsernamePasswordAuthProvider : IAuthProvider
	{
		private IUserRepo userRepo;

		public UsernamePasswordAuthProvider(IUserRepo userRepo)
		{
			this.userRepo = userRepo;
		}
		public void Authenticate(AuthenticationRequest entity)
		{
			var user = userRepo.Get(entity.Identifier) ?? throw new UnknownEntityException();
			//probably do some password hashing etc.
			if (user.Password != entity.Credential)
				throw new InvalidCredentialException();
		}
	}
}
