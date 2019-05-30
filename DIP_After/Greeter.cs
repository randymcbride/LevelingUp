namespace DIP_After
{
	public class Greeter
	{
		private readonly ITranslator translator;

		public Greeter(ITranslator translator)
		{
			this.translator = translator;
		}
		public string Greet(string language, string name)
		{
			return $"{translator.Translate(language)} {name}";
		}
	}
}
