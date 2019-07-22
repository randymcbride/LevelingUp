using System;

namespace OO_Patterns._6_Avoiding_Nulls.After
{
	public class TimeWarranty : IWarranty
	{
		public DateTime IssueDate { get; }
		public TimeSpan Duration { get; }
		public TimeWarranty(DateTime issueDate, TimeSpan duration)
		{
			IssueDate = issueDate;
			Duration = duration;
		}
		public bool IsValidOn(DateTime dateInQuestion) => dateInQuestion < IssueDate + Duration;
	}
}
