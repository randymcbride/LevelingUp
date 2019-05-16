namespace SRP_Before
{
	class Program
	{
		static void Main(string[] args)
		{
			//SRP states that a module should have only one reason to change.
			//The User class breaks SRP in two ways:
			//	1. If email logic changed we would need to update the user class and its instances
			//	2. If our persistance strategy changed then we would need to update it again
			var user = new User
			{
				Name = "Jane Doe",
				Email = "Jane@mail.io"
			};

			user.Save();

			if (user.EmailIsValid)
			{
				user.SendEmail("Welcome", "Welcome to our app");
			}
		}
	}
}
