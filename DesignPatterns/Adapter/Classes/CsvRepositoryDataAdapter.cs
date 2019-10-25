using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Text;

namespace DesignPatterns.Adapter
{
	public class CsvRepositoryDataAdapter<T> : ICsvRepository<T>
	{
		public CsvRepositoryDataAdapter(string filePath)
		{
			FilePath = filePath;
			csvDataAdapter = new CsvDataAdapter(filePath);
		}
		public string FilePath { get; }

		private CsvDataAdapter csvDataAdapter;

		public IEnumerable<T> GetAll()
		{
			var items = new List<T>();
			string line;
			var file = new StreamReader(FilePath);
			while ((line = file.ReadLine()) != null)
			{
				items.Add(Deserialize(line));
			}
			return items;
		}

		public void Insert(T item)
		{
			var dataSet = new DataSet();
			csvDataAdapter.Add(Serialize(item));
			csvDataAdapter.Fill(dataSet);
			csvDataAdapter.Update(dataSet);
		}

		private string Serialize(T item)
		{
			var values = new List<string>();
			foreach (var property in item.GetType().GetProperties())
			{
				string value = property.GetValue(item).ToString();
				values.Add(value);
			}
			return string.Join(",", values);
		}

		private T Deserialize(string line)
		{
			var item = (T)Activator.CreateInstance(typeof(T));
			var values = line.Split(",");
			var properties = item.GetType().GetProperties();
			for (int i = 0; i < values.Length; i++)
			{
				properties[i].SetValue(item, values[i]);
			}
			return item;
		}
	}
}
