using System;

namespace SRP_After
{
	public class EmailEngine
	{
		public void SendEmail(User user, string subject, string message)
		{
			AssertEmailIsValid(user.Email);
			//Send Some Email
			Console.WriteLine($"Sent {subject} email to {user.Name}");
		}

		public void AssertEmailIsValid(string address)
		{
			if (!address.Contains("@"))
			{
				throw new ArgumentException($"The email address {address} is not valid");
			}
		}
	}
}
