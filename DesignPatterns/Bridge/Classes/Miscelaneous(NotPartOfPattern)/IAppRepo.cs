namespace DesignPatterns.Bridge.Classes
{
	public interface IAppRepo
	{
		App Get(string identifier);
	}
}