namespace DesignPatterns.Decorator
{
	public class User : Entity
	{
		[Required]
		public string Username { get; set; }
		[Required]
		public string Email { get; set; }
		public override void Save()
		{
			//do save stuff
		}
	}
}
