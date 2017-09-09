<Query Kind="Program">
  <Reference>&lt;RuntimeDirectory&gt;\System.Runtime.Serialization.dll</Reference>
  <Namespace>System.Runtime.Serialization</Namespace>
  <Namespace>System.Collections.ObjectModel</Namespace>
  <Namespace>System.Runtime.Serialization.Json</Namespace>
  <Namespace>System.Xml.Serialization</Namespace>
</Query>

[DataContract]//, KnownType (typeof (Student)), KnownType (typeof (Teacher))] 
public class Person
{
	[DataMember] public string Name;
	[DataMember] public int Age;
}
[DataContract] public class Student : Person { }
[DataContract] public class Teacher : Person { }

static Person DeepClone (Person p)
{
	var ds = new DataContractSerializer(typeof(Person), new Type[] { typeof (Student), typeof (Teacher) });
	MemoryStream stream = new MemoryStream();
	ds.WriteObject(stream, p);
	stream.Position = 0;
	return (Person)ds.ReadObject (stream);
}

void Main()
{
	Person person = new Person { Name = "Stacey", Age = 30 };
	person.Dump("person = ");
	Student student = new Student { Name = "Stacey", Age = 30 };
	student.Dump("student = ");
	Teacher teacher = new Teacher { Name = "Stacey", Age = 30 };
	teacher.Dump("teacher = ");
	Person p2 = DeepClone (person); // OK
	Student s2 = (Student) DeepClone (student);
	Teacher t2 = (Teacher) DeepClone (teacher);
	p2.Dump("person = ");
	s2.Dump("student = ");
	t2.Dump("teacher = ");
	string path = @"C:\Users\MIB\Desktop\";
	var ds = new DataContractSerializer(typeof(Person), new Type[] { typeof (Student), typeof (Teacher) });
	using (Stream s = File.Create (path + "student.xml"))
  		ds.WriteObject (s, student);      
	//System.Diagnostics.Process.Start (path + "student.xml");
	XDocument.Load(path + "student.xml").Dump();
}