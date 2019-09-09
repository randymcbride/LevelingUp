using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Code_For_Humans
{
	[TestClass]
	public class Conditionals
	{
		[TestMethod]
		public void Explicit_Assignment_Is_Dirty ()
		{
			decimal moneyInWallet = 6m;

			//Don't assign to bools like this
			bool goOutToEat;
			if(moneyInWallet > 7m)
			{
				goOutToEat = true;
			}
			else
			{
				goOutToEat = false;
			}

			Assert.IsFalse(goOutToEat);
		}

		[TestMethod]
		public void Implicit_Assignment_Is_Clean()
		{
			decimal moneyInWallet = 6m;

			//Assign bools implicitly, this is much easier to read;
			bool goOutToEat = moneyInWallet > 7m;

			Assert.IsFalse(goOutToEat);
		}

		[TestMethod]
		public void Use_Positive_Bools()
		{
			//negative bools can be hard to understand some times
			var userNotLoggedIn = false;
			if (!userNotLoggedIn)
			{
				//do secure stuff
			}

			//this is equivalent, but much easier to understand
			var userLoggedIn = true;
			if (userLoggedIn)
			{
				//do secure stuff
			}
		}

		[TestMethod]
		public void Ternary_is_elegant()
		{
			int age = 66;
			double discount;
			//Compare this lengthy statement to the one below it. Which is easier to read? Which is easier to not read (if you didn't care about it)?
			if (age > 65)
			{
				discount = .10;
			}
			else
			{
				discount = 0;
			}

			//ternary statement
			discount = age > 65 ? .10 : 0;

			//avoid chained ternaries
			bool summerSale = false;
			discount = summerSale ? .50 : age > 65 ? .10 : 0;

			//avoid ternaries that are too long, if you have to break it out into multiple lines, consider the traditional approach
		}
	}
}
