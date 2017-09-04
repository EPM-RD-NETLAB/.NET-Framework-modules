<Query Kind="Statements" />

// The foreach statement iterates over each element in an enumerable object.
// The following works because System.String implements IEnumerable<char>:

foreach (char c in "beer")   // c is the iteration variable
	Console.WriteLine (c);