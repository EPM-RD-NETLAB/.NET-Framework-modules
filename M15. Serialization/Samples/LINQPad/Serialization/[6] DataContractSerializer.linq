<Query Kind="Program">
  <Reference>&lt;RuntimeDirectory&gt;\System.Runtime.Serialization.dll</Reference>
  <Namespace>System.Runtime.Serialization</Namespace>
  <Namespace>System.Collections.ObjectModel</Namespace>
  <Namespace>System.Runtime.Serialization.Json</Namespace>
  <Namespace>System.Xml.Serialization</Namespace>
</Query>

//Overriding data member names:

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
	var ds = new DataContractSerializer(typeof(Person));

	MemoryStream s = new MemoryStream();
	//Создает поток, резервным хранилищем которого является память.
	//XmlDictionaryReader может читать формат двоичных XML-данных .NET.
	using (XmlDictionaryWriter w = XmlDictionaryWriter.CreateBinaryWriter(s))
  		ds.WriteObject(w, p);

	MemoryStream s2 = new MemoryStream(s.ToArray());
	Person p2;
	using (XmlDictionaryReader r = XmlDictionaryReader.CreateBinaryReader 
									(s2, XmlDictionaryReaderQuotas.Max))
  		p2 = (Person)ds.ReadObject (r);
	
	p.Dump();
	p2.Dump();
}