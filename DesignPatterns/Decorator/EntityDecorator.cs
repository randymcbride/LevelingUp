namespace DesignPatterns.Decorator
{
	public abstract class EntityDecorator : Entity
	{
		protected readonly Entity entity;

		public EntityDecorator(Entity entity)
		{
			this.entity = entity;
		}
	}
}
