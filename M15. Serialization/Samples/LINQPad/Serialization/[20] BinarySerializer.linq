<Query Kind="Program">
  <Reference>&lt;RuntimeDirectory&gt;\System.Runtime.Serialization.dll</Reference>
  <Namespace>System.Runtime.Serialization</Namespace>
  <Namespace>System.Collections.ObjectModel</Namespace>
  <Namespace>System.Runtime.Serialization.Json</Namespace>
  <Namespace>System.Xml.Serialization</Namespace>
  <Namespace>System.Runtime.Serialization.Formatters.Binary</Namespace>
</Query>

[Serializable] 
public class Person
{
	public string Name;
	public int Age;
}

[Serializable] 
public sealed class Team
{
	public string Name;
	public List<Person> Players = new List<Person>();
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
	IFormatter formatter = new BinaryFormatter();
	using (Stream s = File.Create (path + "serialized.bin"))
		formatter.Serialize (s, team);

	Team team2;
	using (Stream s = File.OpenRead (path + "serialized.bin"))
		team2 = (Team) formatter.Deserialize (s);
	
	team2.Dump();
}