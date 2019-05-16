using System;
using System.IO;
using System.Text;

namespace SRP_Before
{
	public class User
	{
		public string Name { get; set; }
		public string Email { get; set; }
		public bool EmailIsValid => Email.Contains("@");
		public void SendEmail(string subject, string body)
		{
			Console.WriteLine($"Sent {subject} email to {Name}");
		}
		public void Save()
		{
			Console.WriteLine("Saving . . .");
			var stringBuilder = new StringBuilder();
			stringBuilder.AppendLine("Name,Email");
			stringBuilder.AppendLine($"{Name},{Email}");
			File.WriteAllText("data.csv", stringBuilder.ToString());
			Console.WriteLine("Saved");
		}
	}
}
