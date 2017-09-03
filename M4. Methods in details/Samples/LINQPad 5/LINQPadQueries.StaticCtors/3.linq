<Query Kind="Program" />

class Foo
{
	public static Foo Instance = new Foo();
	public static int x = 3;
	Foo() { Console.WriteLine (x); }
}

void Main()
{
	Console.WriteLine(Foo.x);
	Process.Start (@"C:\Program Files (x86)\Red Gate\.NET Reflector\Desktop 8.0\Reflector.exe", 
		Assembly.GetExecutingAssembly().Location);
}