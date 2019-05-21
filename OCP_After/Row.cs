namespace OCP_After
{
	public abstract class Row<T>
	{
		public T Entity { get; set; }
		public int Id { get; set; }
		public Row(T entity, int id)
		{
			Entity = entity;
			Id = id;
		}
		public abstract string ExportCsv();
	}
}
