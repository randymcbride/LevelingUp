using System;

namespace OCP_After
{
	public class UserRow : Row<User>
	{
		public UserRow(User user, int id) : base (user, id)
		{

		}
		public override string ExportCsv()
		{
			return $"{Entity.FirstName},{Entity.LastName},{Entity.DateOfBirth.ToShortDateString()}";
		}
	}
}