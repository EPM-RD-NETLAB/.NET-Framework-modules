<Query Kind="Program">
  <Reference>&lt;RuntimeDirectory&gt;\System.Runtime.Serialization.dll</Reference>
  <Reference>&lt;RuntimeDirectory&gt;\System.Runtime.Serialization.Formatters.Soap.dll</Reference>
  <Namespace>System.Collections.ObjectModel</Namespace>
  <Namespace>System.Runtime.Serialization</Namespace>
  <Namespace>System.Runtime.Serialization.Formatters.Binary</Namespace>
  <Namespace>System.Runtime.Serialization.Json</Namespace>
  <Namespace>System.Xml.Serialization</Namespace>
</Query>

[Serializable] 
public class Person
{
	private string name;
	public string Name {get { return name;} set { name = value;}}
	public int Age;
}

void Main()
{
	string path = @"C:\Users\MIB\Desktop\";
	Person p = new Person() { Name = "Jhon", Age = 25};
	
	//IFormatter formatter = new BinaryFormatter();
	IFormatter formatter = 
		new System.Runtime.Serialization.Formatters.Soap.SoapFormatter();
	using (Stream s = File.Create (path + "serialized.bin"))
		formatter.Serialize (s, p);

	Person p2;
	using (Stream s = File.OpenRead (path + "serialized.bin"))
		p2 = (Person) formatter.Deserialize (s);
	
	p.Dump();
	p2.Dump();
}