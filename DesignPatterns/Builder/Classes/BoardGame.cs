using System.Collections.Generic;

namespace DesignPatterns.Builder.Classes
{
	public class BoardGame
	{
		public string Name { get; internal set; }
		public double ComplexityRating { get; internal set; }
		public List<string> Mechanics { get; internal set; }
		public List<BoardGame> Expansions { get; internal set; }

		public new string ToString() => $@"
			Name: {Name}
			Complexity: {ComplexityRating}
			Mechanics: {string.Join(',', Mechanics)}
		";
	}
}
