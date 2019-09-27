using System.Collections.Generic;

namespace Code_For_Humans.Common.Basketball
{
	public class BoxScore
	{
		public IEnumerable<PlayerGameStatistic> Stats { get; }

		public BoxScore(IEnumerable<PlayerGameStatistic> stats)
		{
			Stats = stats;
		}

		public PlayerGameStatistic ReboundLeader => Stats.WithMax(s => s.Rebounds);
		public PlayerGameStatistic PointLeader => Stats.WithMax(s => s.Points);
		public PlayerGameStatistic AssistLeader => Stats.WithMax(s => s.Assists);
	}
}
