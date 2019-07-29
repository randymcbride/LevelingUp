using OO_Patterns._8_Avoid_switch.Ater;
using System;
using System.Collections.Generic;
using System.Text;

namespace OO_Patterns._8_Avoid_switch.After
{
	class CommonWarrantyRules : IWarrantyMap
	{
		public IReadOnlyDictionary<DeviceStatus, Action<Action>> Create(
			Action<Action> moneyBackClaim,
			Action<Action> notOperationalClaim,
			Action<Action> circuitryClaim) => new Dictionary<DeviceStatus, Action<Action>>
			{
				[DeviceStatus.AllFine()] = moneyBackClaim,
				[DeviceStatus.AllFine().NotOperational()] =
										notOperationalClaim,
				[DeviceStatus.AllFine().WithVisibleDamage()] =
										(action) => { },
				[DeviceStatus.AllFine().NotOperational().WithVisibleDamage()] =
										notOperationalClaim,
				[DeviceStatus.AllFine().CircuitryFailed()] =
										circuitryClaim,
				[DeviceStatus.AllFine().NotOperational().CircuitryFailed()] =
										notOperationalClaim,
				[DeviceStatus.AllFine().CircuitryFailed().WithVisibleDamage()] =
										circuitryClaim,
				[DeviceStatus.AllFine().NotOperational().WithVisibleDamage().CircuitryFailed()] =
										notOperationalClaim
			};
	}
}
