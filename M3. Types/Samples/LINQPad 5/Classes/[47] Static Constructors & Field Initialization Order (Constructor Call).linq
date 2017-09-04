<Query Kind="Program" />

// Another way to go awry:

class Foo
{
	public static Foo Instance = new Foo();
	public static int X = 3;
	
	Foo() { Console.WriteLine (X); }   // 0
}

static void Main()
{
	Console.WriteLine (Foo.X);   // 3
}