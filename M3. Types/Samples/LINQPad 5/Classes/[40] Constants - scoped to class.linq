<Query Kind="Program" />

// Constants are factored out at compile-time and baked into the calling site.

public class Test
{
	public const string Message = "Hello World";
}

static void Main()
{		
	Test.Message.Dump();
}