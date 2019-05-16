using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SRP_After
{
	public class CsvDataStore
	{
		private readonly string fileName;

		public CsvDataStore(string fileName)
		{
			this.fileName = fileName;
		}
		public void SaveUser(User user)
		{
			Console.WriteLine("Saving . . .");
			var stringBuilder = new StringBuilder();
			stringBuilder.AppendLine("Name,Email");
			stringBuilder.AppendLine($"{user.Name},{user.Email}");
			File.WriteAllText(fileName, stringBuilder.ToString());
			Console.WriteLine("Saved");
		}
	}
}
