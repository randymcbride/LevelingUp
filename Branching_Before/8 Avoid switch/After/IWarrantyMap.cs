using OO_Patterns._8_Avoid_switch.After;
using System;
using System.Collections.Generic;

namespace OO_Patterns._8_Avoid_switch.Ater
{
	interface IWarrantyMap
	{
		IReadOnlyDictionary<DeviceStatus, Action<Action>> Create(
			Action<Action> moneyBackClaim,
			Action<Action> notOperationalClaim,
			Action<Action> circuitryClaim);
	}
}