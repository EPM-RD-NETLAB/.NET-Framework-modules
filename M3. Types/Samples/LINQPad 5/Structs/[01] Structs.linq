<Query Kind="Program" />

// A struct is similar to a class, with several key differences (as described in the book).
// In particular, a struct is a value type rather than a reference type.

// The construction semantics are different, too:

public struct Point
{
	public int X, Y;
	public Point (int x, int y) { X = x; Y = y; }
	// The parameterless constructor is implicit.
}

static void Main()
{
	Point p1 = new Point ();       // p1.x and p1.y will be 0
	p1.Dump();
	
	Point p2 = new Point (1, 1);   // p1.x and p1.y will be 1
	p2.Dump();
}