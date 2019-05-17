using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OCP_After
{
	public class UserTable
	{
		public UserTable()
		{
			rows = new List<UserRow>();
			ids = new List<int>();
		}

		public void Insert(User user)
		{
			var row = new UserRow(user, GetNextId());
			rows.Add(row);
		}

		public void SortByFirstName() => rows.OrderBy(row => row.User.FirstName);
		public void SortByLastName() => rows.OrderBy(row => row.User.LastName);
		public void SortByDate() => rows.OrderBy(row => row.User.DateOfBirth);

		public string ExportCsv()
		{
			var stringBuilder = new StringBuilder();
			stringBuilder.AppendLine("First_Name,Last_Name,Date_of_Birth");
			foreach(var row in rows)
			{
				stringBuilder.AppendLine(row.ExportCsv());
			}
			return stringBuilder.ToString();
		}

		private int GetNextId()
		{
			int nextId = ids.Count + 1;
			ids.Add(nextId);
			return nextId;
		}

		private readonly List<UserRow> rows;
		private readonly List<int> ids;
	}
}
