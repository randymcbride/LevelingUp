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
	}
}
