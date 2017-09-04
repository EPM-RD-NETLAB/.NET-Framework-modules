<Query Kind="Program" />

// Any compatible instance method will always take precedence over an extension method:

static void Main()
{
	new Test().Foo ("string");	// Instance method wins, as you'd expect
	new Test().Foo (123);		// Instance method still wins
}

public class Test
{
	public void Foo (object x) { "Instance".Dump(); }    // This method always wins
}

public static class StringHelper
{
	public static void Foo (this UserQuery.Test t, int x) { "Extension".Dump(); }
}