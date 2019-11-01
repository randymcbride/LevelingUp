using DesignPatterns.Bridge.Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace DesignPatterns.Bridge
{
	[TestClass]
	public class Demonstration
	{
		[TestMethod]
		public void Main_Demo()
		{
			var authRequests = new List<AuthenticationRequest>();

			var userRequest = new UserAuthenticationRequest(new UsernamePasswordAuthProvider(new UserRepoMock()));
			userRequest.UserName = "un";
			userRequest.Password = "pw";

			var appRequest = new AppAuthenticationRequest(new TokenAuthProvider(new AppRepoMock()), "myApp");
			appRequest.Token = "token";

			authRequests.Add(userRequest);
			authRequests.Add(appRequest);
		}
	}

	class AppRepoMock : IAppRepo
	{
		public App Get(string identifier)
		{
			if (identifier == "myApp")
				return new App { Token = "token" };
			else
				return null;
		}
	}

	class UserRepoMock : IUserRepo
	{
		public User Get(string identifier)
		{
			if (identifier == "1")
				return new User { UserName = "un", Password = "pw" };
			else
				return null;
		}
	}
}
