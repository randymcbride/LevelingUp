using System;

namespace InterfaceSegregration
{
	/*
	 *The Interface Segregration Prinicple states that no client should should be foreced
	 * to depend on methods it doesn't use. It favors small focuesd classes and interfaces
	 * over large, powerful ones. 
	 *The INotifier Interface violates the Interface segregration prinicple because it forces
	 * clients to implement a SendEmail and SendText method. These should be split into seperate interfaces
	 */
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");
		}
	}
}
