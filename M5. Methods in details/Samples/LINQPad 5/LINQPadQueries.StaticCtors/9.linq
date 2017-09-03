<Query Kind="Program" />

class Parent
{
	static Parent() { Console.WriteLine("Parent Type ctor"); }
	public Parent() { Console.WriteLine("Parent Instance ctor"); }
}

class Child : Parent
{
	static Child() { Console.WriteLine("Child Type ctor"); }
	public Child() { Console.WriteLine("Child Instance ctor"); }
}

class Program
{
	static void Main()
	{
		new Child();
		Console.ReadKey();
	}
}