<Query Kind="Program">
  <Reference>&lt;RuntimeDirectory&gt;\System.Runtime.Serialization.dll</Reference>
  <Namespace>System.Collections.ObjectModel</Namespace>
  <Namespace>System.Runtime.Serialization</Namespace>
  <Namespace>System.Runtime.Serialization.Json</Namespace>
  <Namespace>System.Xml.Serialization</Namespace>
</Query>

public class BaseClass 
{
    public virtual void Do() 
	{
        Console.WriteLine("I am base class");
    }
}

public class DerivedClass : BaseClass 
{
    public DerivedClass() 
	{
        Do();
    }

    public override void Do() 
	{
        Console.WriteLine("I am derived class");
        base.Do();
    }
}

public class DerivedDerivedClass : DerivedClass 
{
    public override void Do() 
	{
        Console.WriteLine("I am derived DerivedClass class ");
        base.Do();
    }
}

void Main() 
{
    BaseClass mustBoom = new DerivedDerivedClass();
}