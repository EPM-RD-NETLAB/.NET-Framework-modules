<Query Kind="Program">
  <Reference>&lt;RuntimeDirectory&gt;\System.Runtime.Serialization.dll</Reference>
  <Namespace>System.Runtime.Serialization</Namespace>
  <Namespace>System.Collections.ObjectModel</Namespace>
  <Namespace>System.Runtime.Serialization.Json</Namespace>
  <Namespace>System.Xml.Serialization</Namespace>
</Query>

[DataContract]public class Person
{
	[DataMember]
	public string Name;
	[DataMember]
	public int Age;
	[DataMember] List<Address> addresses = new List<Address>();
	public IList<Address> Addresses {get {return addresses;}}
}

[DataContract] public class Address
{
    [DataMember] public string Street, Postcode;
}

void Main()
{
	Person person = new Person { Name = "Stacey", Age = 30 };
	person.Addresses.Add(new Address { Street = "Fawcett St", Postcode = "02138" });
	person.Addresses.Add(new Address { Street = "Comer St", Postcode = "06152" });
	
	var ds = new DataContractSerializer(typeof(Person));
	string path = @"C:\Users\MIB\Desktop\";
	using (Stream s = File.Create (path + "person.xml"))
  		ds.WriteObject (s, person);                            // Serialize

	Person p2;
	using (Stream s = File.OpenRead (path + "person.xml"))
  		p2 = (Person) ds.ReadObject (s);                  // Deserialize
	
	person.Dump();
	p2.Dump();
//	System.Diagnostics.Process.Start (path + "person.xml");
	XDocument.Load(path + "person.xml").Dump();
}