<Query Kind="Program">
  <Reference>&lt;RuntimeDirectory&gt;\System.Runtime.Serialization.dll</Reference>
  <Namespace>System.Xml.Serialization</Namespace>
</Query>

//дочерние объекты
//при наличии двух свойств или полей, которые ссылаются на один и тот же объект, 
//объект сериализуется дважды
public class Person
{
	public string Name;
	public Address HomeAddress = new Address();
	public Address WorkAddress = new Address();
}

public class Address { public string Street, PostCode; }

public void SerializePerson (Person p, string path)
{
	XmlSerializer xs = new XmlSerializer (typeof (Person));
	using (Stream s = File.Create (path))
		xs.Serialize (s, p);
}

void Main()
{
	Person p = new Person(); p.Name = "Stacey";
	p.HomeAddress.Street = "Odo St";
	p.HomeAddress.PostCode = "6020";
	p.WorkAddress = p.HomeAddress;
	p.Dump();
	string path = @"C:\Users\MIB\Desktop\";
	
	SerializePerson(p, path + "person.xml");

	//System.Diagnostics.Process.Start (path + "person.xml");
	XDocument.Load(path + "person.xml").Dump();
}