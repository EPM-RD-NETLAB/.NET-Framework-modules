<Query Kind="Program">
  <Reference>&lt;RuntimeDirectory&gt;\System.Runtime.Serialization.dll</Reference>
  <Namespace>System.Xml.Serialization</Namespace>
</Query>

//подклассы 2-ой способ
public class Person { public string Name; }
public class Student : Person { }
public class Teacher : Person { }

public void SerializePerson (Person p, string path)
{
	XmlSerializer xs = new XmlSerializer (typeof (Person), 
							new Type[] { typeof(Student), typeof(Teacher)});
	using (Stream s = File.Create (path))
		xs.Serialize (s, p);
}

void Main()
{
	Teacher p = new Teacher { Name = "Stacey" };
	p.Dump();
	string path = @"C:\Users\MIB\Desktop\";
	
	SerializePerson(p, path + "person.xml");

	//System.Diagnostics.Process.Start (path + "person.xml");
	XDocument.Load(path + "person.xml").Dump();
}