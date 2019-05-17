using System;

namespace OCP_After
{
	public class Program
	{
		static void Main(string[] args)
		{
			var userJane = new User
			{
				FirstName = "Jane",
				LastName = "Doe",
				DateOfBirth = new DateTime(1990, 1, 1)
			};
			var userJohn = new User
			{
				FirstName = "John",
				LastName = "Doe",
				DateOfBirth = new DateTime(2000, 1, 1)
			};

			var table = new UserTable();
			table.Insert(userJane);
			table.Insert(userJohn);
			Console.WriteLine(table.ExportCsv());
		}
	}
}
