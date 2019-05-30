using System;

namespace DIP_After
{
	public class Translator : ITranslator
	{
		public string Translate(string language)
		{
			switch (language)
			{
				case "en":
					return "hello";
				case "es":
					return "hola";
				default:
					throw new NotImplementedException($"the langage {language} is not supported");
			}
		}
	}
}