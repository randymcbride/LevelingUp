using System.Collections.Generic;
using System.Data;
using System.IO;

namespace DesignPatterns.Adapter
{
	public class CsvDataAdapter : IDataAdapter
	{
		public CsvDataAdapter(string filePath)
		{
			rows = new List<string>();
			this.filePath = filePath;
		}
		public void Add(string row)
		{
			rows.Add(row);
		}
		public MissingMappingAction MissingMappingAction { get; set; }
		public MissingSchemaAction MissingSchemaAction { get; set; }

		public ITableMappingCollection TableMappings { get; }

		public int Fill(DataSet dataSet)
		{
			var rowsAdded = 0;
			foreach (var row in rows)
			{
				for (int i = 0; i < dataSet.Tables.Count; i++)
				{
					var table = dataSet.Tables[i];
					table.Rows.Add(row);
					rowsAdded++;
				}
			}
			return rowsAdded;
		}

		public int Update(DataSet dataSet)
		{
			var rowsInserted = 0;
			using (var streamWriter = new StreamWriter(filePath))
			{
				for (int i = 0; i < dataSet.Tables.Count; i++)
				{
					var table = dataSet.Tables[i];
					for (int j = 0; j < table.Rows.Count; j++)
					{
						streamWriter.WriteLine(table.Rows[j]);
						rowsInserted++;
					}
				}
			}
			return rowsInserted;
		}

		public DataTable[] FillSchema(DataSet dataSet, SchemaType schemaType)
		{
			throw new System.NotImplementedException();
		}

		public IDataParameter[] GetFillParameters()
		{
			throw new System.NotImplementedException();
		}
		private List<string> rows;
		private string filePath;
	}
}
