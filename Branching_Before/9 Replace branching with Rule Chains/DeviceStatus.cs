using System;

namespace OO_Patterns._9_ChainRules
{
	sealed class DeviceStatus
	{
		[Flags]
		private enum OperationalStateEnum
		{
			FullyOperational = 0,
			NotOperational = 1,
			VisibleDamage = 2,
			FailedCircuitry = 4
		}

		private OperationalStateEnum OperationalStatus { get; }

		private DeviceStatus(OperationalStateEnum operationalStatus)
		{
			OperationalStatus = operationalStatus;
		}

		public static DeviceStatus AllFine() =>
		new DeviceStatus(OperationalStateEnum.FullyOperational);

		public DeviceStatus WithVisibleDamage() =>
				new DeviceStatus(this.OperationalStatus | OperationalStateEnum.VisibleDamage);

		public DeviceStatus NotOperational() =>
				new DeviceStatus(this.OperationalStatus | OperationalStateEnum.NotOperational);

		public DeviceStatus Repaired() =>
				new DeviceStatus(this.OperationalStatus & ~OperationalStateEnum.NotOperational);

		public DeviceStatus CircuitryFailed() =>
				new DeviceStatus(this.OperationalStatus | OperationalStateEnum.FailedCircuitry);

		public DeviceStatus CircuitryReplaced() =>
				new DeviceStatus(this.OperationalStatus & ~OperationalStateEnum.FailedCircuitry);
	}
}