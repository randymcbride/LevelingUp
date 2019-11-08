using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Builder.Classes
{
	public class BrassBurminghamBuilder : BoardGameBuilder
	{
		public override void AddGameDetails()
		{
			BoardGame.Name = "Brass Burmingham";
			BoardGame.ComplexityRating = 4.1;
		}

		public override void AddGameMechanics()
		{
			BoardGame.Mechanics = new List<string> { "Resource Management", "Route Building" };
		}

		public override void AddExpansions()
		{
			BoardGame.Expansions = new List<BoardGame>();
		}
	}
}
