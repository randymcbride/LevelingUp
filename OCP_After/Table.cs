using System;
using System.Collections.Generic;

namespace OCP_After
{
	public abstract class Table<EntityType, RowType> where RowType : Row<EntityType>
	{
		private readonly List<Row<EntityType>> rows;
		private readonly List<int> ids;

		public Table()
		{
			rows = new List<Row<EntityType>>();
			ids = new List<int>();
		}

		public void Insert(EntityType entity)
		{
			RowType row = (RowType)Activator.CreateInstance(typeof(RowType), new object[] { entity });
			rows.Add(row);
		}

		private int GetNextId()
		{
			int nextId = ids.Count + 1;
			ids.Add(nextId);
			return nextId;
		}
	}
}
