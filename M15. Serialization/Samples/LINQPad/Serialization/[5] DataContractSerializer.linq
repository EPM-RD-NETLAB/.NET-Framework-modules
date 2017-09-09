<Query Kind="Program">
  <Reference>&lt;RuntimeDirectory&gt;\System.Runtime.Serialization.dll</Reference>
  <Namespace>System.Runtime.Serialization</Namespace>
  <Namespace>System.Collections.ObjectModel</Namespace>
  <Namespace>System.Runtime.Serialization.Json</Namespace>
  <Namespace>System.Xml.Serialization</Namespace>
</Query>

//Formatting the output:
//Both types of serializer use the XML formatter by default

//Specifying a name and namespace decouples the contract identity
//from the .NET type name. It ensures that, should you later
//refactor and change the type’s name or namespace, serialization
//is unaffected

[DataContract(Name="Candidate", Namespace="http://mmf.bsu.by")] 
public class Person
{
	[DataMember(Name="FirstName")]
	public string Name;
	
	[DataMember(Name="ClaimedAge")]
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