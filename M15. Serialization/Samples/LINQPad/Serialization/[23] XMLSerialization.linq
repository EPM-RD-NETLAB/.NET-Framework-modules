<Query Kind="Program">
  <Reference>&lt;RuntimeDirectory&gt;\System.Runtime.Serialization.dll</Reference>
  <Namespace>System.Xml.Serialization</Namespace>
</Query>

//XmlSerializer can serialize types without any attributes—such as our Person type
//By default, it serializes all public fields and properties on a type

public class Person
{
	public string Name;
	public int Age;
	[XmlIgnore] //You can exclude members you don’t want serialized
	public bool Valid = true;// Выполняется перед десериализацией
	//Не распознает атрибут [OnDeserializing], 
	//полагается на конструктор без параметров
	//Person has an implicit parameterless constructor
	//public Person(int i){}
}

void Main()
{
	Person p = new Person() { Name = "Stacey", Age = 30};
	p.Dump();
	string path = @"C:\Users\MIB\Desktop\";
	XmlSerializer xs = new XmlSerializer (typeof (Person));
	//Stream, XmlWriter/XmlReader, or TextWriter/TextReader
	using (Stream s = File.Create (path + "person.xml"))
		xs.Serialize (s, p);
	Person p2;
	using (Stream s = File.OpenRead (path + "person.xml"))
 		p2 = (Person) xs.Deserialize (s);
	p2.Dump();
//	System.Diagnostics.Process.Start (path + "person.xml");
	XDocument.Load(path + "person.xml").Dump();
}