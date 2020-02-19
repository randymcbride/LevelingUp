using System;
using System.Runtime.Serialization;

namespace DesignPatterns.Facade
{
	[Serializable]
	internal class UnmappedAddressException : Exception
	{
		public UnmappedAddressException()
		{
		}

		public UnmappedAddressException(string message) : base(message)
		{
		}

		public UnmappedAddressException(string message, Exception innerException) : base(message, innerException)
		{
		}

		protected UnmappedAddressException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}
	}
}