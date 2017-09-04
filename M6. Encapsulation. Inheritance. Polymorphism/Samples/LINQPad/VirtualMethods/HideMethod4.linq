<Query Kind="Program">
  <Reference>&lt;RuntimeDirectory&gt;\System.Runtime.Serialization.dll</Reference>
  <Namespace>System.Collections.ObjectModel</Namespace>
  <Namespace>System.Runtime.Serialization</Namespace>
  <Namespace>System.Runtime.Serialization.Json</Namespace>
  <Namespace>System.Xml.Serialization</Namespace>
</Query>

void Main()
{
	D d = new D(); C c = d; 
	B b = c; A a = b;
    d.M(); c.M(); b.M(); a.M();
}
class A 
{
   public virtual void M() { Console.Write("A"); }
}
class B: A 
{
   public override void M() { Console.Write("B"); }
}
class C: B
{
   new public virtual void M() { Console.Write("C"); }
}
class D: C
{
   public override void M() { Console.Write("D"); }
}


