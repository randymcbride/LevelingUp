using Code_For_Humans.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Diagnostics;

namespace Code_For_Humans
{
	[TestClass]
	public class PreferPolymorphismToConditionals
	{
		[TestMethod]
		public void ConditionalsThatDetermineLogicAreDirty()
		{
			var user = new User();
			//don't do this
			if (user.IsActive)
			{
				user.IsLoggedIn = true;
			}
			else
			{
				Debug.WriteLine("User is inactive. They cannot login");
			}
			Assert.IsFalse(user.IsLoggedIn);
		}

		private void ObjectsCanCoupleStateWithLogic()
		{
			//One of the major wins for OO programming is the fact that
			//state is coupled with behavior. No need to branch over conditions using if or switch statements
			//Just set the objects state and tell it to do its thing
			//this is easier to understand and more reusable
			var inactiveUser = new InactiveUser();
			inactiveUser.Login();
			Assert.IsFalse(inactiveUser.IsLoggedIn);

			var activeUser = inactiveUser.Activate();
			activeUser.Login();
			Assert.IsTrue(activeUser.IsLoggedIn);
		}
	}
}
