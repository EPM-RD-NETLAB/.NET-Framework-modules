<Query Kind="Program" />

// The extension method with more specific arguments wins. Classes & structs are
// considered more specific than interfaces:

static void Main()
{
	string[] strings = { "a", "b", null, "c"};
	foreach (string s in strings.StripNulls())
		Console.WriteLine (s);
}

static class Test
{
	public static IEnumerable<T> StripNulls<T> (this IEnumerable<T> seq)
	{
		foreach (T t in seq)
			if (t != null)
				yield return t;
	}
}