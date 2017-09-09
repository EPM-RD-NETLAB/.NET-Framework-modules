<Query Kind="Program">
  <Reference>&lt;RuntimeDirectory&gt;\System.Runtime.Serialization.dll</Reference>
  <Namespace>System.Runtime.Serialization</Namespace>
  <Namespace>System.Collections.ObjectModel</Namespace>
  <Namespace>System.Runtime.Serialization.Json</Namespace>
  <Namespace>System.Xml.Serialization</Namespace>
</Query>

//Formatting the output:
//Both types of serializer use the XML formatter by default

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
	DataContractSerializer ds = new DataContractSerializer (typeof (Person));
	
	string path = @"C:\Users\MIB\Desktop\";
	
	XmlWriterSettings settings = new XmlWriterSettings() { Indent = true };
	using (XmlWriter w = XmlWriter.Create (path + "person.xml", settings))
  		ds.WriteObject (w, p);

	//System.Diagnostics.Process.Start (path + "person.xml");
	XDocument.Load(path + "person.xml").Dump();
}