using System;

namespace OO_Patterns._7_Optional_Objects
{
	public class TimeWarranty : IWarranty
	{
		Action defatultCallback = () => { };
		public DateTime IssueDate { get; }
		public TimeSpan Duration { get; }
		public TimeWarranty(DateTime issueDate, TimeSpan duration)
		{
			IssueDate = issueDate;
			Duration = duration;
		}
		private bool IsValidOn(DateTime dateInQuestion) => dateInQuestion < IssueDate + Duration;

		public void Claim(DateTime date, Action onValidClaim = null)
		{
			onValidClaim = onValidClaim ?? defatultCallback;
			if (IsValidOn(date))
				onValidClaim();
		}
	}
}
