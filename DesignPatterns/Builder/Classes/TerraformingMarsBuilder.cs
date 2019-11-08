using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Builder.Classes
{
	public class TerraformingMarsBuilder : BoardGameBuilder
	{
		public override void AddGameDetails()
		{
			BoardGame.Name = "Terraforming Mars";
			BoardGame.ComplexityRating = 3.6;
		}

		public override void AddGameMechanics()
		{
			BoardGame.Mechanics = new List<string> { "Hand Mangement", "EngineBuilding" };
		}

		public override void AddExpansions()
		{
			BoardGame.Expansions = new List<BoardGame>
			{
				new BoardGame{ Name = "Terraforming Mars: Colonies"}
			};
		}
	}
}
