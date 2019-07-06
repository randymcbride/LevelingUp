using System;

namespace OO_Patterns._6_Avoiding_Nulls.Before
{
	public class Warranty
	{
		public DateTime IssueDate { get; }
		public TimeSpan Duration { get; }
		public Warranty(DateTime issueDate, TimeSpan duration)
		{
			IssueDate = issueDate;
			Duration = duration;
		}
	}
}
