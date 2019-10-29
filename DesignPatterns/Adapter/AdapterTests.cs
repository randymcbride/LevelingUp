using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace DesignPatterns.Adapter
{
	[TestClass]
	public class AdapterTests
	{
		[TestMethod]
		public void Demomstrate()
		{
			var dataAdapter = new CsvRepositoryDataAdapter<User>(@"C:\dev\sandbox\tempFiles\Users.csv");
			var userRepo = new UserRepository(dataAdapter);
			var userList = userRepo.GetAll();
			var user = new User
			{
				Email = "u@m.com",
				UserName = "user1"
			};
			userRepo.Insert(user);
			var updatedUserList = userRepo.GetAll();
			Assert.IsTrue(userList.Count() == updatedUserList.Count() - 1);
		}
	}
}
