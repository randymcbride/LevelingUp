using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace DesignPatterns.Command.Classes.Commands
{
	public class WriteLineCommand : ICommand
	{
		public string Message { get; set; }
		public Action<ICommand> OnFail { get; set; }

		public int FailCount { get; private set; }
		public TimeSpan Wait { get; set; }

		public async Task ExecuteAsync()
		{
			if (Wait != TimeSpan.Zero)
				await Task.Delay(Convert.ToInt32(Wait.TotalMilliseconds));
			if (string.IsNullOrEmpty(Message))
			{
				FailCount++;
				OnFail(this);
			}
			else
			{
				Debug.WriteLine(Message);
			}
		}
	}
}
