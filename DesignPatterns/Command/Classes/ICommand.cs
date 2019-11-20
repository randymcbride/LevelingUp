using System;
using System.Threading.Tasks;

namespace DesignPatterns.Command.Classes
{
	public interface ICommand
	{
		Action<ICommand> OnFail { get; set; }
		Task ExecuteAsync();
		int FailCount { get; }
	}
}
