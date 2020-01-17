using Newtonsoft.Json;
using System;

namespace DesignPatterns.Decorator
{
	public class ChangeLog
	{
		public ChangeLog(object item)
		{
			Log =  JsonConvert.SerializeObject(item);
			Date = DateTime.Now;
		}

		public string Log { get; }
		public DateTime Date { get; }
	}
}