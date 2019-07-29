using System;

namespace OO_Patterns._8_Avoid_switch.Before
{
	[Flags]
	public enum OperationalStateEnum
	{
		FullyOperational = 0,
		NotOperational = 1,
		VisibleDamage = 2,
		BrokenCircuitry = 4
	}
}
