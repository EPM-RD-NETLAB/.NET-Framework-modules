<Query Kind="Program">
  <Reference>&lt;RuntimeDirectory&gt;\System.Runtime.Serialization.dll</Reference>
  <Namespace>System.Runtime.Serialization</Namespace>
  <Namespace>System.Collections.ObjectModel</Namespace>
  <Namespace>System.Runtime.Serialization.Json</Namespace>
  <Namespace>System.Xml.Serialization</Namespace>
</Query>

//Basic use of DataContractSerializer

[DataContract] 
public class Person
{
	[DataMember]
	public string Name;
	
	[DataMember]
	public int Age;
}

void Main()
{
	Person p = new Person { Name = "Stacey", Age = 30 };

	var ds = new NetDataContractSerializer();
	string path = @"C:\Users\MIB\Desktop\";
	using (Stream s = File.Create (path + "person.xml"))
  		ds.WriteObject (s, p);                            // Serialize

	Person p2;
	using (Stream s = File.OpenRead (path + "person.xml"))
  		p2 = (Person) ds.ReadObject (s);                  // Deserialize

	p.Dump();
	p2.Dump();
	//System.Diagnostics.Process.Start (path + "person.xml");
	XDocument.Load(path + "person.xml").Dump();
}