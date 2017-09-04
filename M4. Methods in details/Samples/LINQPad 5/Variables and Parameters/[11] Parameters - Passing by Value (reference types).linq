<Query Kind="Program" />

// Passing a reference-type argument by value copies the reference, not the object:

static void Foo (StringBuilder fooSB)
{
	fooSB.Append ("test");
	fooSB = null;
}

static void Main()
{
	StringBuilder sb = new StringBuilder();
	Foo (sb);
	Console.WriteLine (sb.ToString());    // test
}