using System;

namespace DIP_Before
{
	class Program
	{
		/*
		 * The Dependcy Inversion Principle states that high level modules should not depend
		 * on low level modules; both should depend on abstractions. Abstractions should not depend
		 * on details, rather, details should depend on abstractions.
		 * 
		 * The Greeter class doesn't adhere to DIP because it depends on Translator, which is a
		 * lower level detail. Greeter should not be concerned with what is doing the translation
		 * only that it is getting done.
		 */
		static void Main(string[] args)
		{
			var greeter = new Greeter();
			Console.WriteLine(greeter.Greet("en", "Randy"));
			Console.WriteLine(greeter.Greet("es", "Randy"));
		}
	}
}
