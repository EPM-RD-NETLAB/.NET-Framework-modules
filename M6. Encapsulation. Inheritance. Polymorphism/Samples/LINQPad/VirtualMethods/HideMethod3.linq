<Query Kind="Program">
  <Reference>&lt;RuntimeDirectory&gt;\System.Runtime.Serialization.dll</Reference>
  <Namespace>System.Collections.ObjectModel</Namespace>
  <Namespace>System.Runtime.Serialization</Namespace>
  <Namespace>System.Runtime.Serialization.Json</Namespace>
  <Namespace>System.Xml.Serialization</Namespace>
</Query>

void Main()
{
	Baz baz = new Baz(); 
	baz.Foo();
	((Bar)baz).Foo(); // calls base one
	Bar bazAsBar = baz;
	bazAsBar.Foo();
	((Baz)bazAsBar).Foo(); // calls derived one
}

class Bar 
{
	public void Foo() { Console.WriteLine("Bar.Foo"); }
	public static void Qux() { Console.WriteLine("Bar.Qux"); } 
}
class Baz : Bar 
{
	public new void Foo() { Console.WriteLine("Baz.Foo"); }
	public new static void Qux() { Console.WriteLine("Baz.Qux"); } 
}