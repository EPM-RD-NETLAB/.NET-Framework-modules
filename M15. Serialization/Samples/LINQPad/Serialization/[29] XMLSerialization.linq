<Query Kind="Program">
  <Reference>&lt;RuntimeDirectory&gt;\System.Runtime.Serialization.dll</Reference>
  <Namespace>System.Xml.Serialization</Namespace>
</Query>

//сериализация коллекций

public class Person
{
	public string Name;
	public List<Address> Addresses = new List<Address>();
}

public class Address { public string Street, PostCode; }

void Main()
{
	Person p = new Person(); p.Name = "Stacey";
	p.Addresses.Add(new Address { Street = "Odo St", PostCode = "6020" });
	p.Addresses.Add(new Address { Street = "Odo St", PostCode = "6020" });
	p.Dump();
		
	string path = @"C:\Users\MIB\Desktop\";
	
	XmlSerializer xs = new XmlSerializer (typeof (Person));
	using (Stream s = File.Create (path + "person.xml"))
		xs.Serialize (s, p);
		
	Person p2;
	
	using (Stream s = File.OpenRead (path + "person.xml"))
 		p2 = (Person) xs.Deserialize (s);
	p2.Dump();
	
	//System.Diagnostics.Process.Start (path + "person.xml");
	XDocument.Load(path + "person.xml").Dump();
}