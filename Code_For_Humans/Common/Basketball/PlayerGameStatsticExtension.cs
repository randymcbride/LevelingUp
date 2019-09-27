using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_For_Humans.Common.Basketball
{
	public static class PlayerGameStatsticExtension
	{
		public static PlayerGameStatistic WithMax(this IEnumerable<PlayerGameStatistic> statistics, Func<PlayerGameStatistic, int> getValueFunc)
		{
			int maxValue = int.MinValue;
			PlayerGameStatistic maxStat = null;
			foreach (var stat in statistics)
			{
				int value = getValueFunc(stat);
				if (value > maxValue)
				{
					maxValue = value;
					maxStat = stat;
				}
			}
			return maxStat;
		}
	}
}
