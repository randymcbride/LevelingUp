namespace DIP_Before
{
	public class Greeter
	{
		public string Greet(string language, string name)
		{
			var translator = new Translator();
			return $"{translator.Translate(language)} {name}";
		}
	}
}
