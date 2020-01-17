using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Decorator
{
	public abstract class Entity
	{
		public int Id { get; set; }
		public abstract void Save();
	}
}
