namespace OCP_After
{
	public class EmailRow : Row<Email>
	{
		public EmailRow(Email email, int id) : base(email, id)
		{

		}
		public override string ExportCsv()
		{
			return $"{Entity.Address},{Entity.IsValidated}";
		}
	}
}