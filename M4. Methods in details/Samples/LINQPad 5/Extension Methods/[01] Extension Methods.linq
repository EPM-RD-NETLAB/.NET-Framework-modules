<Query Kind="Program" />

// Extension methods allow an existing type to be extended with new methods without altering
// the definition of the original type:

// (Note that these examples will not work in older versions of LINQPad)

static void Main()
{
	Console.WriteLine ("Perth".IsCapitalized());	
	// Equivalent to:
	Console.WriteLine (StringHelper.IsCapitalized ("Perth"));	
	
	// Interfaces can be extended, too:
	Console.WriteLine ("Seattle".First());   // S
}

public static class StringHelper
{
	public static bool IsCapitalized (this string s)
	{
		if (string.IsNullOrEmpty(s)) return false;
		return char.IsUpper (s[0]);
	}
	
	public static T First<T> (this IEnumerable<T> sequence)
	{
		foreach (T element in sequence)
			return element;
		
		throw new InvalidOperationException ("No elements!");
	}
}