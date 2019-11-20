using System.Collections.Generic;

namespace DesignPatterns.Command.Classes
{
	public class CommandQueue
	{
		private Queue<ICommand> commands = new Queue<ICommand>();
		private bool processing;
		public static int FailureLimit = 4;

		public int TotalAttempts { get; private set; }
		public int FailCount { get; private set; }

		public void Add(ICommand command)
		{
			command.OnFail = failedCommand =>
			{
				if (failedCommand.FailCount < FailureLimit)
					commands.Enqueue(failedCommand);
				else
					FailCount++;
			};
			commands.Enqueue(command);
			InitiateProcessing();
		}

		private void InitiateProcessing()
		{
			if (!processing)
			{
				processing = true;
				ProcessCommands();
				processing = false;
			}
		}

		private void ProcessCommands()
		{
			ICommand currentCommand;
			while (commands.TryDequeue(out currentCommand))
			{
				TotalAttempts++;
				currentCommand.ExecuteAsync();
			};
		}
	}
}
