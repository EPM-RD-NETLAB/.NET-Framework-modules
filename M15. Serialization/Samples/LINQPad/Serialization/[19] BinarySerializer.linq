<Query Kind="Program">
  <Reference>&lt;RuntimeDirectory&gt;\System.Runtime.Serialization.dll</Reference>
  <Namespace>System.Runtime.Serialization</Namespace>
  <Namespace>System.Collections.ObjectModel</Namespace>
  <Namespace>System.Runtime.Serialization.Json</Namespace>
  <Namespace>System.Xml.Serialization</Namespace>
  <Namespace>System.Runtime.Serialization.Formatters.Binary</Namespace>
</Query>

[Serializable] 
public sealed class Person
{
	public string Name;
	public DateTime DateOfBirth;
	[NonSerialized] public int Age;
	[NonSerialized] public bool Valid = true;
	public Person() { Valid = true; }
	
	[OnDeserializing]
	void OnDeserializing (StreamingContext context)
	{
		Valid = true;
	}
	
	[OnDeserialized]
	void OnDeserialized (StreamingContext context)
	{
		Age = (DateTime.Now - DateOfBirth).Days / 365; // Rough age in years
	}	
}

void Main()
{
	string path = @"C:\Users\MIB\Desktop\";
	Person p = new Person() 
		{ Name = "George", DateOfBirth = new DateTime(2008, 1, 23)};
	p.Age = (DateTime.Now - p.DateOfBirth).Days / 365;
	IFormatter formatter = new BinaryFormatter();
	using (Stream s = File.Create (path + "serialized.bin"))
		formatter.Serialize (s, p);

	Person p2;
	using (Stream s = File.OpenRead (path + "serialized.bin"))
		p2 = (Person) formatter.Deserialize (s);
	
	p.Dump();
	p2.Dump();
}