using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Decorator
{
	[TestClass]
	public class Demonstration
	{
		[TestMethod]
		public void Demo()
		{
			//setting up the test
			Entity user = new User
			{
				Id = 1,
				Email = "my.email@mail.net",
				Username = "myusername"
			};
			var changeLog = new List<ChangeLog>();

			//We decorate (wrap) the user in an instance of AuditEntityDecorator.
			//User does not know about AuditEntityDecorator. As far as it knows it is just
			//going about its business as usual. The decorator is adding behavior without user being affected at all.
			//The reason we can do this is because AuditEntityDecorator inherits from Entity and User inerits from Entity.
			user = new AuditEntityDecorator(user, changeLog);
			//Wrap it again
			user = new ValidationEntityDecorator(user);

			user.Save();
			Assert.IsTrue(changeLog.Count > 0);
		}

		[TestMethod, ExpectedException(typeof(ArgumentException))]
		public void Demo2()
		{
			//Same idea as above, just demonstrating that the ValidationEntityDecorator is actually working.
			Entity user = new User
			{
				Id = 1
				//Username and Email are flagged as required (see the class definition)
			};

			var changeLog = new List<ChangeLog>();
			user = new ValidationEntityDecorator(user);

			user.Save();
		}
	}
}
