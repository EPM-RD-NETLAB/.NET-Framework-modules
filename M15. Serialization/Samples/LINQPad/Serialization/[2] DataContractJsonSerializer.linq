<Query Kind="Program">
  <Reference>&lt;RuntimeDirectory&gt;\System.Runtime.Serialization.dll</Reference>
  <Namespace>System.Runtime.Serialization</Namespace>
  <Namespace>System.Collections.ObjectModel</Namespace>
  <Namespace>System.Runtime.Serialization.Json</Namespace>
  <Namespace>System.Xml.Serialization</Namespace>
</Query>

//JSON (англ. JavaScript Object Notation) — текстовый формат обмена данными, 
//основанный на JavaScript и обычно используемый именно с этим языком. 
//Как и многие другие текстовые форматы, JSON легко читается людьми
//http://www.json.org/json-ru.html

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
	DataContractJsonSerializer ds = 
		new System.Runtime.Serialization.DataContractSerializer (typeof (Person));
	
	string path = @"C:\Users\MIB\Desktop\";
	
	XmlWriterSettings settings = new XmlWriterSettings() { Indent = true };
	using (XmlWriter w = XmlWriter.Create (path + "person.json", settings))
  		ds.WriteObject (w, p);

	XDocument.Load(path + "person.json").Dump();
}