namespace DesignPatterns.EventAggregator.Classes
{
	public interface ISubscribe<T>
	{
		void OnEvent(T genericEvent);
	}
}
