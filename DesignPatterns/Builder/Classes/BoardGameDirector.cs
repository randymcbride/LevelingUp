namespace DesignPatterns.Builder.Classes
{
	public class BoardGameDirector
	{
		public BoardGame Build(BoardGameBuilder builder)
		{
			builder.AddGameDetails();
			builder.AddGameMechanics();
			builder.AddExpansions();
			return builder.BoardGame;
		}
	}
}
