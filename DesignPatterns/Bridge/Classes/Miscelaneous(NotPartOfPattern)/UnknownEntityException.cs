using System;
using System.Runtime.Serialization;

namespace DesignPatterns.Bridge.Classes
{
	[Serializable]
	internal class UnknownEntityException : Exception
	{
		public UnknownEntityException()
		{
		}

		public UnknownEntityException(string message) : base(message)
		{
		}

		public UnknownEntityException(string message, Exception innerException) : base(message, innerException)
		{
		}

		protected UnknownEntityException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}
	}
}