<Query Kind="Program" />

// When calling an overload method, the method with the most specific 
// parameter type match has precedence, based on the *compile-time* variable type:

static void Main()
{
	Foo (new House());		// Calls Foo (House)
	
	Asset a = new House();
	Foo (a);				// Calls Foo (Asset)
}

static void Foo (Asset a) { "Foo Asset".Dump(); }
static void Foo (House h) { "Foo House".Dump(); }

public class Asset
{
	public string Name;
}

public class Stock : Asset   // inherits from Asset
{
	public long SharesOwned;
}

public class House : Asset   // inherits from Asset
{
	public decimal Mortgage;
}