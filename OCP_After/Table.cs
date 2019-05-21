using System;
using System.Collections.Generic;
using System.Text;

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
			RowType row = (RowType)Activator.CreateInstance(typeof(RowType), entity, GetNextId());
			rows.Add(row);
		}
		public string ExportCsv()
		{
			var stringBuilder = new StringBuilder();
			stringBuilder.AppendLine(GetCsvHeader());
			foreach (var row in rows)
			{
				stringBuilder.AppendLine(row.ExportCsv());
			}
			return stringBuilder.ToString();
		}

	protected abstract string GetCsvHeader();

	private int GetNextId()
	{
		int nextId = ids.Count + 1;
		ids.Add(nextId);
		return nextId;
	}
}
}
