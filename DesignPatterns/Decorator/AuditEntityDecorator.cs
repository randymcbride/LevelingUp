using System.Collections.Generic;

namespace DesignPatterns.Decorator
{
	public class AuditEntityDecorator : EntityDecorator
	{
		public List<ChangeLog> ChangeLog { get; }
		public AuditEntityDecorator(Entity entity, List<ChangeLog> changeLog) : base(entity)
		{
			ChangeLog = changeLog;
		}

		public override void Save()
		{
			entity.Save();
			ChangeLog.Add(new ChangeLog(entity));
		}
	}
}
