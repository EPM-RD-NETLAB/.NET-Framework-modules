<Query Kind="Program">
  <Reference>&lt;RuntimeDirectory&gt;\System.Runtime.Serialization.dll</Reference>
  <Namespace>System.Collections.ObjectModel</Namespace>
  <Namespace>System.Runtime.Serialization</Namespace>
  <Namespace>System.Runtime.Serialization.Json</Namespace>
  <Namespace>System.Xml.Serialization</Namespace>
</Query>

class Base
{
    public Base()
    {
        Console.WriteLine(100 / GetValue());
    }

    protected virtual Int32 GetValue()
    {
        return 1;
    }
}

class Derived : Base
{
	private int value;
	public Derived()
	{
		value = 2;
	}

    protected override int GetValue()
    {
        return value;
    }
}

class Program
{
    static void Main()
    {
		Console.WriteLine(new Base());
        Console.WriteLine(new Derived());
    }
}