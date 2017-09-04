<Query Kind="Program" />

// The extension method with more specific arguments wins. Classes & structs are
// considered more specific than interfaces:

static void Main()
{
	"Perth".IsCapitalized().Dump();
}

static class StringHelper
{
	public static bool IsCapitalized (this string s)
	{
		"StringHelper.IsCapitalized".Dump();
		return char.IsUpper (s[0]);
	}
}

static class EnumerableHelper
{
	public static bool IsCapitalized (this IEnumerable<char> s)
	{
		"Enumerable.IsCapitalized".Dump();
		return char.IsUpper (s.First());
	}
}