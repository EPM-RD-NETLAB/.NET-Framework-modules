<Query Kind="Program">
  <Reference>&lt;RuntimeDirectory&gt;\System.Runtime.Serialization.dll</Reference>
  <Namespace>System.Collections.ObjectModel</Namespace>
  <Namespace>System.Runtime.Serialization</Namespace>
  <Namespace>System.Runtime.Serialization.Json</Namespace>
  <Namespace>System.Xml.Serialization</Namespace>
</Query>

void Main()
{
	Bar bar = new Bar(); 
	bar.Foo();
	Bar.Qux();
	Baz baz = new Baz(); 
	baz.Foo();
	Baz.Qux();
	Bar bazAsBar = baz; 
	bazAsBar.Foo();
}

class Bar 
{
	public void Foo() { Console.WriteLine("Bar.Foo"); }
	public static void Qux() { Console.WriteLine("Bar.Qux"); } 
}
class Baz : Bar 
{
	public int Foo() { Console.WriteLine("Baz.Foo");return 0; }
	public static void Qux() { Console.WriteLine("Baz.Qux"); } 
}