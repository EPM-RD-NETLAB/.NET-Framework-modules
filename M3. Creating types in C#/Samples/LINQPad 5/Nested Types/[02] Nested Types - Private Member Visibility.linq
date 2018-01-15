<Query Kind="Program" />

public class TopLevel
{
	static int x;
	public class Nested
	{
		public static void Foo() { Console.WriteLine (TopLevel.x); }
	}
}

static void Main()
{
	TopLevel.Nested.Foo();
}

