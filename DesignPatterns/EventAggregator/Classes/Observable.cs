using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.EventAggregator.Classes
{
	public class Observable
	{
		private readonly IEventAggregator eventAggregator;

		public Observable(IEventAggregator eventAggregator)
		{
			this.eventAggregator = eventAggregator;
		}

		public void Observable1()
		{
			//some logic
			eventAggregator.Publish(new Event1());
		}

		public void Observable2()
		{
			//some logic
			eventAggregator.Publish(new Event2());
		}
	}
}
