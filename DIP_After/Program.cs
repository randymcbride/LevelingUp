using System;

namespace DIP_After
{
	class Program
	{
		/*
		 * The Greeter class now adheres to DIP because it depends on an abstraction of
		 * ITranslator. ITranslator does not depend on the details. The details are contained
		 * in the Translator class which also depends on ITranslator. The main entry point of our program
		 * is in charge of injecting the concrete instance of ITranslator when it creates the Greeter instance.
		 */
		static void Main(string[] args)
		{
			var greeter = new Greeter(new Translator());
			Console.WriteLine(greeter.Greet("en", "Randy"));
			Console.WriteLine(greeter.Greet("es", "Randy"));
		}
	}
}
