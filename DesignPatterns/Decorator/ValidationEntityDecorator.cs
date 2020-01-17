using System;
using System.Reflection;

namespace DesignPatterns.Decorator
{
	public class ValidationEntityDecorator : EntityDecorator
	{
		public ValidationEntityDecorator(Entity entity) : base(entity)
		{
		}

		public override void Save()
		{
			ValidateEntity();
			entity.Save();
		}

		private void ValidateEntity()
		{
			var properties = entity.GetType().GetProperties();
			foreach (var property in properties)
			{
				if (IsRequired(property) && !HasValue(property))
					throw new ArgumentException($"{property.Name} is required");
			}
		}

		private bool HasValue(PropertyInfo property)
		{
			return !string.IsNullOrEmpty(property.GetValue(entity)?.ToString());
		}

		private bool IsRequired(PropertyInfo property)
		{
			return Attribute.IsDefined(property, typeof(RequiredAttribute));
		}
	}
}
