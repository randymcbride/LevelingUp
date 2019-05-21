namespace OCP_After
{
	public class UserTable : Table<User, UserRow>
	{
		protected override string GetCsvHeader() => "First_Name,Last_Name,Date_of_Birth";
	}
}
