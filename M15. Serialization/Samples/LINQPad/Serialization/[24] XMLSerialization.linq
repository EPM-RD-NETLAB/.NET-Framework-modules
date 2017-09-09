<Query Kind="Program">
  <Reference>&lt;RuntimeDirectory&gt;\System.Runtime.Serialization.dll</Reference>
  <Namespace>System.Xml.Serialization</Namespace>
</Query>

//Стандартное пространство имен является пустым 
//(в отличие от сериализатора контрактов данных,
//который использует пространство имен типа)
[XmlRoot ("Candidate", Namespace = "http://mynamespace/test/")]
public class Person
{
	//по умолчанию поля и свойства сериализуются в XML-элементы
	[XmlElement ("FirstName")] 
	public string Name;
	
	//[XmlAttribute] 
	[XmlAttribute ("RoughAge")] 
	public int Age;
}

void Main()
{
	Person p = new Person { Name = "Stacey", Age = 30 };
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