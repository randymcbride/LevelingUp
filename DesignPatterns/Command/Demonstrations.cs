using DesignPatterns.Command.Classes;
using DesignPatterns.Command.Classes.Commands;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Threading;

namespace DesignPatterns.Command
{
	[TestClass]
	public class Demonstrations
	{
		[TestMethod]
		public void ExecutesWritlineCommands()
		{
			var helloCommand = new WriteLineCommand { Message = "Hello" };
			var worldCommand = new WriteLineCommand { Message = "World" };
			var commandQueue = new CommandQueue();

			commandQueue.Add(helloCommand);
			commandQueue.Add(worldCommand);

			Assert.AreEqual(0, commandQueue.FailCount);
			Assert.AreEqual(2, commandQueue.TotalAttempts);
		}

		[TestMethod]
		public void RetriesUntilFailureLimit()
		{
			var helloCommand = new WriteLineCommand { Message = "" };
			var worldCommand = new WriteLineCommand { Message = "World" };
			var commandQueue = new CommandQueue();

			commandQueue.Add(helloCommand);
			commandQueue.Add(worldCommand);

			int expectedSuccessCount = 1;
			Assert.AreEqual(1, commandQueue.FailCount);
			Assert.AreEqual(CommandQueue.FailureLimit + expectedSuccessCount, commandQueue.TotalAttempts);
		}

		[TestMethod]
		public void ExecutesCommandsAsync()
		{
			//This will print World /n Hello
			var helloCommand = new WriteLineCommand { Message = "Hello", Wait = TimeSpan.FromSeconds(1) };
			var worldCommand = new WriteLineCommand { Message = "World" };
			var commandQueue = new CommandQueue();

			commandQueue.Add(helloCommand);
			commandQueue.Add(worldCommand);

			Thread.Sleep(2000);

			Assert.AreEqual(0, commandQueue.FailCount);
			Assert.AreEqual(2, commandQueue.TotalAttempts);
		}

		[TestMethod]
		public void ProcessesAsyncInsertAndUpdates()
		{
			throw new NotImplementedException();
		}
	}
}
