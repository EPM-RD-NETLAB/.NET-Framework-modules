<Query Kind="Program" />

// Static data is unique for each closed type:

class Bob<T> { public static int Count; }

static void Main()
{
	Console.WriteLine (++Bob<int>.Count);     // 1
	Console.WriteLine (++Bob<int>.Count);     // 2
	Console.WriteLine (++Bob<string>.Count);  // 1
	Console.WriteLine (++Bob<object>.Count);  // 1
}

