<Query Kind="Program" />

// Extension methods, like instance methods, provide a tidy way to chain functions:

static void Main()
{
	string x = "sausage".Pluralize().Capitalize();
	x.Dump();
	
	// Equivalent to:
	string y = StringHelper.Capitalize (StringHelper.Pluralize ("sausage"));
	y.Dump();
	
	// LINQPad's Dump method is an extension method:
	"sausage".Pluralize().Capitalize().Dump();
}

public static class StringHelper
{
	public static string Pluralize (this string s) => s + "s";   // Very naiive implementation!
	
	public static string Capitalize (this string s) => s.ToUpper();
}