<Query Kind="Program" />

public class TopLevel
{
	protected class Nested { }
}

public class SubTopLevel : TopLevel
{
	static void Foo() { new TopLevel.Nested(); }
}

static void Main()
{
}

