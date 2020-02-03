using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.EventAggregator.Classes
{
	public interface IEventAggregator
	{
		List<object> Subscribers { get; }

		void Publish<T>(T genericEvent);
	}
}
