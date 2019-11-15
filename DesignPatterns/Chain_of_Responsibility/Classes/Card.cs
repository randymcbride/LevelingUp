namespace DesignPatterns.Chain_of_Responsibility.Classes
{
	public class Card
	{
		public Card(string suit, string value)
		{
			Suit = suit;
			Value = value;
		}

		public string Suit { get; set; }
		public string Value { get; set; }
	}
}
