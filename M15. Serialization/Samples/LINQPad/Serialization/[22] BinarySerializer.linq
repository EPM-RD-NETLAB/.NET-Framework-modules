<Query Kind="Program">
  <Reference>&lt;RuntimeDirectory&gt;\System.Runtime.Serialization.dll</Reference>
  <Reference>&lt;RuntimeDirectory&gt;\System.Runtime.Serialization.Formatters.Soap.dll</Reference>
  <Namespace>System.Runtime.Serialization</Namespace>
  <Namespace>System.Collections.ObjectModel</Namespace>
  <Namespace>System.Runtime.Serialization.Json</Namespace>
  <Namespace>System.Xml.Serialization</Namespace>
  <Namespace>System.Runtime.Serialization.Formatters.Binary</Namespace>
  <Namespace>System.Runtime.Serialization.Formatters.Soap</Namespace>
</Query>

[Serializable] 
public class Person
{
	public string Name;
	public int Age;
}

[Serializable] 
public class Team : ISerializable
{
	public string Name;
	public List<Person> Players = new List<Person>();
	
	public virtual void GetObjectData (SerializationInfo si, StreamingContext sc)
	{
		si.AddValue ("Name", Name);
		si.AddValue ("PlayerData", Players.ToArray());
	}
	
	public Team() {}
	
	private Team (SerializationInfo si, StreamingContext sc)//protected...
	{
		Name = si.GetString ("Name");
		// Deserialize Players to an array to match our serialization:
		Person[] a = (Person[]) si.GetValue ("PlayerData", typeof (Person[]));
		// Construct a new List using this array:
		Players = new List<Person> (a);
	}
}

void Main()
{
	string path = @"C:\Users\MIB\Desktop\";
	Person person = new Person { Name = "Stacey", Age = 30 };
	Person person2 = new Person { Name = "John", Age = 23 };
	Team team = new Team() { Name = "Team" };
	team.Players.Add(person);
	team.Players.Add(person2); 
	team.Dump();
	IFormatter formatter = new SoapFormatter();
	using (Stream s = File.Create (path + "serialized.xml"))
		formatter.Serialize (s, team);

	Team team2;
	using (Stream s = File.OpenRead (path + "serialized.xml"))
		team2 = (Team) formatter.Deserialize (s);
	
	team2.Dump();
}