namespace SRP_After
{
	class Program
	{
		static void Main(string[] args)
		{
			//With the responsibilites of emailing and persisting data reallocated to seperate classes,
			//each class in the solution become short succinct peices of functionality that specializes in one thing.
			//Refactoring in the future becomes much simpler.
			var emailEngine = new EmailEngine();
			var csvDataStore = new CsvDataStore("data.csv");
			var user = new User
			{
				Name = "Jane Doe",
				Email = "Jane@mail.io"
			};
			emailEngine.SendEmail(user, "Welcome", "Welcome to our app");
			csvDataStore.SaveUser(user);
		}

	}
}
