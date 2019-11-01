namespace DesignPatterns.Bridge.Classes
{
	public interface IUserRepo
	{
		User Get(string identifier);
	}
}