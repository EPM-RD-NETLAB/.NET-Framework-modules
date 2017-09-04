<Query Kind="Program">
  
  <Namespace>System.Dynamic</Namespace>
</Query>

void Main()
{
	var command = new SqlCommand ("select top 3 * from Purchase", (SqlConnection) Connection);
	Connection.Open();
	using (IDataReader reader = command.ExecuteReader (CommandBehavior.CloseConnection))
	{
		dynamic dr = new DynamicReader (reader);
		while (reader.Read())
		{
			int id = dr.ID;
			string description = dr.Description;
			DateTime date = dr.Date;
			decimal price = dr.Price;
			new { description, date, price }.Dump();
		}
	}
}

public class DynamicReader : DynamicObject
{
	readonly IDataRecord _dataRecord;
	public DynamicReader (IDataRecord dr) { _dataRecord = dr; }
	
	public override bool TryGetMember (GetMemberBinder binder,
										out object result)
	{
		result = _dataRecord [binder.Name];
		return true;
	}
}

