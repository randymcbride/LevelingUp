using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Builder.Classes
{
	public abstract class BoardGameBuilder
	{
		public BoardGameBuilder()
		{
			BoardGame = new BoardGame();
		}

		public BoardGame BoardGame { get; }

		public abstract void AddGameDetails();
		public abstract void AddGameMechanics();
		public abstract void AddExpansions();
	}
}
