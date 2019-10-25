using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace DesignPatterns.Adapter
{
	public interface ICsvRepository<T>
	{
		string FilePath { get; }
		IEnumerable<T> GetAll();
		void Insert(T item);
	}
}
