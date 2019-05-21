namespace OCP_After
{
	public class EmailTable : Table<Email, EmailRow>
	{
		protected override string GetCsvHeader() => "Address,IsValidated";
	}
}
