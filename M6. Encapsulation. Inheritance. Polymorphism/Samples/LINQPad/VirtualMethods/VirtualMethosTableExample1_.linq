<Query Kind="Program">
  <Reference>&lt;RuntimeDirectory&gt;\System.Runtime.Serialization.dll</Reference>
  <Namespace>System.Collections.ObjectModel</Namespace>
  <Namespace>System.Runtime.Serialization</Namespace>
  <Namespace>System.Runtime.Serialization.Json</Namespace>
  <Namespace>System.Xml.Serialization</Namespace>
</Query>

//«слот» для виртуальной функции корректно инициализируется сразу
//же при создании объекта 
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
	private Int32 value;
	public Derived()
	{
		value = 2;
	}

    protected override Int32 GetValue() => value;
}

class Program
{
    static void Main()
    {
		Console.WriteLine(new Base());// all ok
        Console.WriteLine(new Derived());//Attempted to divide by zero -> DivideByZeroException
    }
}