using System;

namespace OCP_Before
{
	public class UserRow
	{
		public UserRow(User user, int id)
		{
			User = user;
			Id = id;
		}

		public int Id { get; set; }
		public User User { get; set; }

		internal string ExportCsv()
		{
			return $"{User.FirstName},{User.LastName},{User.DateOfBirth.ToShortDateString()}";
		}
	}
}