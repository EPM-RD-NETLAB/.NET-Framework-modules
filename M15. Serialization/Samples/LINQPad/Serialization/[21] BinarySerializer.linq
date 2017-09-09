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

//SOAP форматер не работает с обобщенными типами
[Serializable] 
public class Person
{
	public string Name;
	public int Age;
}

[Serializable] public sealed class Team
{
	public string Name;
	Person[] _playersToSerialize;
	
	[NonSerialized] public List<Person> Players = new List<Person>();
	
	[OnSerializing]
	void OnSerializing (StreamingContext context)
	{
		_playersToSerialize = Players.ToArray();
	}
	
	[OnSerialized]
	void OnSerialized (StreamingContext context)
	{
		_playersToSerialize = null; // Allow it to be freed from memory
	}
	
	[OnDeserialized]
	void OnDeserialized (StreamingContext context)
	{
		Players = new List<Person> (_playersToSerialize);
	}
}

void Main()
{
	string path = @"C:\Users\MIB\Desktop\";
	Person person = new Person { Name = "Stacey", Age = 30 };
	Person person2 = new Person { Name = "John", Age = 23 };
	Team team = new Team() 
	{
		Name = "Team"
	};
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