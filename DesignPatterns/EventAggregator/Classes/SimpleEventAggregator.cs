using System.Collections.Generic;

namespace DesignPatterns.EventAggregator.Classes
{
	public class SimpleEventAggregator : IEventAggregator
	{
		public List<object> Subscribers { get; } = new List<object>();
		public void Publish<T>(T genericEvent)
		{
			foreach (var subscriber in Subscribers)
			{
				if (subscriber is ISubscribe<T> eventSubscriber)
				{
					eventSubscriber.OnEvent(genericEvent);
				}
			}
		}
	}
}
