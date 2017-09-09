<Query Kind="Program">
  <Reference>&lt;RuntimeDirectory&gt;\System.Runtime.Serialization.dll</Reference>
  <Namespace>System.Runtime.Serialization</Namespace>
  <Namespace>System.Collections.ObjectModel</Namespace>
  <Namespace>System.Runtime.Serialization.Json</Namespace>
  <Namespace>System.Xml.Serialization</Namespace>
</Query>

//C# 5.0 in a Nutshell, Fifth Edition by Joseph Albahari and Ben Albahari
//17. Serialization
//http://msdn.microsoft.com/en-us/library/system.runtime.serialization.xmlobjectserializer(v=vs.110).aspx
//Basic use of DataContractSerializer

[DataContract] 
public class Person
{
	[DataMember()]//поддерживает как поля, так и свойства - открытые и закрытые
	//[DataMember(EmitDefaultValue=false)]
	private string name;
	[DataMember]
	public string SomeProp{ get; set;}
	[DataMember]
	public int Age;
}

void Main()
{
	Person p = new Person { Age = 23, SomeProp = "test" };

	var ds = new DataContractSerializer(typeof(Person));
	string path = @"C:\Users\MIB\Desktop\";
	using (Stream s = File.Create (path + "person.xml"))
	//public static FileStream Open(string path,FileMode mode)
  		ds.WriteObject (s, p);                            // Serialize

	Person p2;
	using (Stream s = File.OpenRead (path + "person.xml"))
  		p2 = (Person) ds.ReadObject (s);                  // Deserialize
	
	p.Dump();
	p2.Dump();
	System.Diagnostics.Process.Start (path + "person.xml");
	XDocument.Load(path + "person.xml").Dump();
}