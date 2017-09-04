<Query Kind="Program">
  <Reference>&lt;RuntimeDirectory&gt;\System.Runtime.Serialization.dll</Reference>
  <Namespace>System.Collections.ObjectModel</Namespace>
  <Namespace>System.Runtime.Serialization</Namespace>
  <Namespace>System.Runtime.Serialization.Json</Namespace>
  <Namespace>System.Xml.Serialization</Namespace>
</Query>

void Main()
{
	string s = "Hello";
	object o = s;
	
	Console.WriteLine(o.ToString());
	
	Print(o);
	
	Person bart = new Student("Bart", 27, "C# Academy"); 
	Person lisa = new Student("Lisa", 23, "VB Academy");
	Console.WriteLine(bart.ToString());// OO.Student (the full type name) 
	Console.WriteLine(bart.Equals(lisa)); // false (no reference equality)
	Console.WriteLine(lisa.GetHashCode()); // Some 32-bit integer value
	Console.WriteLine(lisa.GetType());// OO.Student (ToString of Type object)
	o = lisa;
	Console.WriteLine(o.GetType());// OO.Student (ToString of Type object)
}

static void Print(object o) 
{
	Console.WriteLine(o); // Console.WriteLine will call ToString on o. 
}

//public class Object 
//{
//	public virtual bool Equals(object obj) { /* default implementation */ } 
//	public virtual int GetHashCode() { /* default implementation */ } 
//	public virtual string ToString() { /* default implementation */ } 
//	public Type GetType() { /* the one and only implementation */ }
//	//... 
//}

class Person
{
	
}

class Student : Person
{
	public Student(string name, int age, string work)
	{
		this.Name = name;
		this.Age = age;
		this.Work = work;
	}
	public int Age { get; set; }
	public string Name { get; set; }
	public string Work { get; set; }
}