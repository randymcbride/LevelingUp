using DesignPatterns.EventAggregator.Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DesignPatterns.EventAggregator
{
	[TestClass]
	public class Demonstration
	{
		[TestMethod]
		public void Demo()
		{
			//eventAggregator will tie the observer to the observable, without the two knowing about eachother.
			var eventAggregator = new SimpleEventAggregator();

			//Has two methods that fire Event1 and Event2 when called. Does not know that the Observer class exists.
			var observableClass = new Observable(eventAggregator);

			//Observes anything that fires Event1 and Event2. Does not know that the Observalbe class exists.
			var observer = new Observer(eventAggregator);

			//Fire Event1
			observableClass.Observable1();
			//Fire Event2
			observableClass.Observable2();

			//Tests that (1) the events fired, (2) they were observed, and (3) the observer can distinguish between events.
			Assert.AreEqual(2, observer.ObservedEvents.Count);
			Assert.IsInstanceOfType(observer.ObservedEvents[0], typeof(Event1));
			Assert.IsInstanceOfType(observer.ObservedEvents[1], typeof(Event2));

			//Aditional features: By design this is a simple implementation. In a production envioronment the EventAggregator would use strategies 
			//to make it performant and memory safe (like WeakReference class) and thread safe (like lock statement).
		}
	}
}
