/*
 * Notice the code for the program in this project looks identical to the code in OCP_Before.
 * The changes are in how we create a UserTable and UserRow. These classes inherit from Table
 * and Row abstract classes respectivley. Now that they follow OCP we can extend our app much easier.
 * Take a look at the Email table to see just how easy it is.
 * 
 * The current implementation might still break OCP. The potential problem is if we add a property to User we will
 * need to update the UserTable and UserRow classes. This illustrates the crux of the problem OCP is trying to solve.
 * It encourages us to constantly ask the question--what is the proper level of abstraction?
 * In this case I asked myself, how often will User's properties change? If they do change,
 * how many modificaitons will I need to make. In this case I determined that User will not change often, and if it ever does
 *  changing the UserRow and UserTable class is very simple. Adding an additional level of complicated abstraction for something
 *  that is fairly rigid in our app just doesn't make practical sense.
 */

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
			Console.WriteLine("Runing OCP_AFTER . . .");
			Console.WriteLine(table.ExportCsv());
		}
	}
}
