<Query Kind="Program" />

void Main()
{
	object x = 5;
	object y = 5;
	Console.WriteLine (x.Equals (y));      // True
	
	Console.WriteLine (AreEqual (x, y));		// True
	Console.WriteLine (AreEqual (null, null));	// True
}

// Here's an example of how we can leverage the virtual Equals mehtod:
public static bool AreEqual (object obj1, object obj2)
{
	if (obj1 == null) return obj2 == null;
	return obj1.Equals (obj2);
	// What we've written is in fact equivalent to the static object.Equals method!
}