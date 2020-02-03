using System.Collections.Generic;

namespace DesignPatterns.EventAggregator.Classes
{
	public class Observer : ISubscribe<Event1>, ISubscribe<Event2>
	{
		public Observer(IEventAggregator eventAggregator)
		{
			eventAggregator.Subscribers.Add(this);
		}
		public List<object> ObservedEvents { get; } = new List<object>();
		public void OnEvent(Event2 event2)
		{
			ObservedEvents.Add(event2);
		}

		public void OnEvent(Event1 event1)
		{
			ObservedEvents.Add(event1);
		}
	}
}
